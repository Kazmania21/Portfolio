import abc
import pygame
from pygame import freetype
import typing
import shapes
import other_physics
if typing.TYPE_CHECKING:
    import entities
    import bricks
    import hud


class IState(metaclass=abc.ABCMeta):
    def __init__(self, win_state: "IState" = None, lose_state: "IState" = None,
                 play_state: "IState" = None, pause_state: "IState" = None):
        self.win_state = win_state
        self.lose_state = lose_state
        self.play_state = play_state
        self.pause_state = pause_state

    @abc.abstractmethod
    def win(self) -> "IState": ...

    @abc.abstractmethod
    def lose(self) -> "IState": ...

    @abc.abstractmethod
    def play(self) -> "IState": ...

    @abc.abstractmethod
    def pause(self) -> "IState": ...


class WinState(IState):
    def __init__(self, screen: pygame.Surface, ball: "entities.IMovingEntity", slider: "entities.IVisibleEntity",
                 state_text: shapes.ITextShape, lives: "hud.ILivesHUD" = None,
                 destroyed_brick_mediator: "bricks.IDestroyedBrickMediator" = None):
        self.screen = screen
        self.ball = ball
        self.slider = slider
        self.state_text = state_text
        self.lives = lives
        self.destroyed_brick_mediator = destroyed_brick_mediator
        super().__init__()

    def win(self) -> IState:
        return self.win_state

    def lose(self) -> IState:
        return self.lose_state

    def play(self) -> IState:
        self.state_text.change_text("")
        self.ball.get_position().reset()
        self.ball.get_velocity().reset()
        self.slider.get_position().reset()
        self.lives.add(1)
        self.destroyed_brick_mediator.return_bricks()
        return self.play_state

    def pause(self) -> IState:
        return self.pause_state


class LoseState(IState):
    def __init__(self, win_state: IState, screen: pygame.Surface, ball: "entities.IMovingEntity",
                 slider: "entities.IVisibleEntity", state_text: shapes.ITextShape, score: "hud.INumberHUD" = None,
                 lives: "hud.ILivesHUD" = None, destroyed_brick_mediator: "bricks.IDestroyedBrickMediator" = None):
        self.screen = screen
        self.ball = ball
        self.slider = slider
        self.state_text = state_text
        self.score = score
        self.lives = lives
        self.destroyed_brick_mediator = destroyed_brick_mediator
        super().__init__(win_state=win_state)

    def win(self) -> IState:
        return self.win_state

    def lose(self) -> IState:
        return self.lose_state

    def play(self) -> IState:
        self.state_text.change_text("")
        self.ball.get_position().reset()
        self.ball.get_velocity().reset()
        self.slider.get_position().reset()
        self.lives.reset()
        self.score.reset()
        self.destroyed_brick_mediator.return_bricks()
        return self.play_state

    def pause(self) -> IState:
        return self.pause_state


class PlayState(IState):
    def __init__(self, win_state: IState, lose_state: IState, pause_state: IState,
                 victory_font: freetype.Font, lose_font: freetype.Font, screen: pygame.Surface,
                 ball: "entities.IMovingEntity", state_text: shapes.ITextShape, score: "hud.INumberHUD" = None):
        self.victory_font = victory_font
        self.lose_font = lose_font
        self.screen = screen
        self.ball = ball
        self.state_text = state_text
        self.score = score
        super().__init__(win_state, lose_state, self, pause_state)

    def win(self) -> IState:
        self.state_text.change_font(self.victory_font)
        self.state_text.change_text("YOU WIN!")
        self.ball.get_velocity().change(0, 0)
        self.score.add(100)
        return self.win_state

    def lose(self) -> IState:
        self.state_text.change_font(self.lose_font)
        self.state_text.change_text("YOU LOSE!")
        self.ball.get_velocity().change(0, 0)
        self.ball.get_position().y = self.screen.get_height()
        return self.lose_state

    def play(self) -> IState:
        return self.play_state

    def pause(self) -> IState:
        self.pause_state.velocity.x = self.ball.get_velocity().x
        self.pause_state.velocity.y = self.ball.get_velocity().y
        self.state_text.change_text("Paused")
        self.ball.get_velocity().change(0, 0)
        return self.pause_state


class PauseState(IState):
    def __init__(self, win_state: IState, lose_state: IState, ball: "entities.IMovingEntity",
                 state_text: shapes.ITextShape):
        self.ball = ball
        self.velocity: other_physics.IGraphPhysics = other_physics.Velocity(0, 0)
        self.state_text = state_text
        super().__init__(win_state, lose_state)

    def win(self) -> IState:
        return self.win_state

    def lose(self) -> IState:
        return self.lose_state

    def play(self) -> IState:
        self.ball.get_velocity().change(self.velocity.x, self.velocity.y)
        self.state_text.change_text("")
        return self.play_state

    def pause(self) -> IState:
        return self.pause_state


class IStateManager(metaclass=abc.ABCMeta):
    @abc.abstractmethod
    def win(self) -> None: ...

    @abc.abstractmethod
    def lose(self) -> None: ...

    @abc.abstractmethod
    def play(self) -> None: ...

    @abc.abstractmethod
    def pause(self) -> None: ...

    @abc.abstractmethod
    def get_state(self) -> None: ...


class StateManager(IStateManager):
    def __init__(self, state: IState):
        self.state = state
        self.button_text: typing.Optional["shapes.ITextShape"] = None

    def win(self) -> None:
        self.button_text.change_text("Play Again")
        self.button_text.change_font(freetype.Font("../atari_breakout/ARCADECLASSIC.TTF", 30))
        self.state = self.state.win()

    def lose(self) -> None:
        self.button_text.change_text("Play Again")
        self.button_text.change_font(freetype.Font("../atari_breakout/ARCADECLASSIC.TTF", 30))
        self.state = self.state.lose()

    def play(self) -> None:
        self.button_text.change_text("Pause")
        self.button_text.change_font(freetype.Font("../atari_breakout/ARCADECLASSIC.TTF", 50))
        self.state = self.state.play()

    def pause(self) -> None:
        self.button_text.change_text("Play")
        self.button_text.change_font(freetype.Font("../atari_breakout/ARCADECLASSIC.TTF", 50))
        self.state = self.state.pause()

    def get_state(self) -> IState:
        return self.state
