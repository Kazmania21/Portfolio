import pygame
import pygame.freetype
import entities
import collision_physics
import other_physics
import hud
import shapes
import bricks
import actions
import state
import pygame.sprite

if __name__ == '__main__':
    """GAME SETTINGS"""
    pygame.init()
    screen = pygame.display.set_mode((1280, 720))
    clock = pygame.time.Clock()
    running = True
    dt = 0
    GAME_FONT = pygame.freetype.Font('../atari_breakout/ARCADECLASSIC.TTF', 340)
    LOSE_FONT = pygame.freetype.Font('../atari_breakout/ARCADECLASSIC.TTF', 295)
    text_position = other_physics.Position(screen.get_width() / 2, screen.get_height() / 2)
    text = shapes.Text(screen, (255, 0, 0), text_position, GAME_FONT, "", centered=True)

    """Slider and ball settings"""
    player_pos = other_physics.Position(screen.get_width() / 2 - 80, screen.get_height() / 2)
    velocity = other_physics.Velocity(300, 300)

    slider_position = other_physics.Position(screen.get_width() / 2 - 80, screen.get_height() / 2 + 90)

    circle = shapes.Circle(screen, "green", player_pos, 40)
    ball = entities.Ball(circle, player_pos, velocity)
    slider_shape = shapes.Rectangle(screen, "red", slider_position, 160, 80)
    slider = entities.Slider(slider_shape, slider_position)

    ball_collider_action = actions.Bounce(ball)

    ball_polygon = collision_physics.CirclePolygon(ball, action=ball_collider_action)
    slider_polygon = collision_physics.RectanglePolygon(slider)

    ball_collider = collision_physics.CircleCollider(ball, ball_polygon)
    slider_collider = collision_physics.SquareCollider(slider, slider_polygon)

    """State Instantiation"""

    win_state = state.WinState(screen, ball, slider, text)
    lose_state = state.LoseState(win_state, screen, ball, slider, text)
    pause_state = state.PauseState(win_state, lose_state, ball, text)
    play_state = state.PlayState(win_state, lose_state, pause_state, GAME_FONT, LOSE_FONT, screen, ball, text)

    win_state.win_state = win_state
    win_state.lose_state = lose_state
    win_state.play_state = play_state
    win_state.pause_state = pause_state
    lose_state.lose_state = lose_state
    lose_state.play_state = play_state
    lose_state.pause_state = pause_state
    pause_state.play_state = play_state
    pause_state.pause_state = pause_state

    state_manager = state.StateManager(play_state)
    slider.state_manager = state_manager

    """HUD Instantiation"""
    hud_outline_shape = shapes.Rectangle(screen, "grey", other_physics.Position(0, screen.get_height() / 4 * 3), screen.get_width(), 20)
    hud_bg_shape = shapes.Rectangle(screen, "black", other_physics.Position(0, screen.get_height() / 4 * 3), screen.get_width(),
                             int(screen.get_height() / 4))
    hud_outline = hud.Background(hud_outline_shape, other_physics.Position(0, screen.get_height() / 4 * 3))
    hud_background = hud.Background(hud_bg_shape, other_physics.Position(0, screen.get_height() / 4 * 3))

    lives_position = other_physics.Position(100, screen.get_height() / 4 * 3 + 100)
    lives_text_position = other_physics.Position(150, screen.get_height() / 4 * 3 + 75)
    lives_logo = shapes.Circle(screen, "green", lives_position, 40)
    lives_text = shapes.Text(screen, (255, 0, 0), lives_text_position, pygame.freetype.Font('../atari_breakout/ARCADECLASSIC.TTF', 100), "")
    lives = hud.Lives(lives_logo, 3, lives_text, state_manager)
    lives.draw(dt)
    win_state.lives = lives
    lose_state.lives = lives

    state_button_position = other_physics.Position(450, screen.get_height() / 4 * 3 + 20)
    state_font = pygame.freetype.Font("../atari_breakout/ARCADECLASSIC.TTF", 50)
    state_text_position = other_physics.Position(600, screen.get_height() / 4 * 3 + 99)
    state_text = shapes.Text(screen, (255, 0, 0), state_text_position, state_font, "Pause", centered=True)
    state_button = hud.StateButton(screen, (0, 0, 0), state_button_position, state_text, "../atari_breakout/rounded button.png")
    state_polygon = collision_physics.RectanglePolygon(state_button)
    state_collider = collision_physics.SquareCollider(state_button, state_polygon)
    state_manager.button_text = state_text

    score_position = other_physics.Position(750, screen.get_height() / 4 * 3 + 75)
    score_font = pygame.freetype.Font('../atari_breakout/PressStart2P-vaV7.ttf', 45)
    score_text = shapes.Text(screen, (255, 0, 0), score_position, score_font, "")
    score = hud.Score(score_text)
    lose_state.score = score
    play_state.score = score

    """Border Instantiation"""
    # slider2 = Slider(pygame, screen, "blue", [screen.get_width() / 2 - 80, screen.get_height() / 2 + 90], 80, 40)
    top_border = entities.Border(other_physics.Position(-300, -300), screen.get_width() + 600, 300)
    right_border = entities.Border(other_physics.Position(screen.get_width(), -300), 300, screen.get_height() + 600)
    bottom_border = entities.Border(other_physics.Position(-300, screen.get_height()), screen.get_width() + 600, 300)
    left_border = entities.Border(other_physics.Position(-300, -300), 300, screen.get_height() + 600)

    bottom_border_action = actions.LoseLife(lives, ball, slider)

    top_border_polygon = collision_physics.BarrierPolygon(top_border)
    right_border_polygon = collision_physics.BarrierPolygon(right_border)
    bottom_border_polygon = collision_physics.BarrierPolygon(bottom_border, action=bottom_border_action)
    left_border_polygon = collision_physics.BarrierPolygon(left_border)

    top_border_collider = collision_physics.BarrierCollider(top_border, top_border_polygon)
    right_border_collider = collision_physics.BarrierCollider(right_border, right_border_polygon)
    bottom_border_collider = collision_physics.BarrierCollider(bottom_border, bottom_border_polygon)
    left_border_collider = collision_physics.BarrierCollider(left_border, left_border_polygon)

    """Collision Checker Settings"""
    collision_checker = collision_physics.CollisionChecker()
    collision_checker.register(ball_collider)
    collision_checker.register(slider_collider)
    collision_checker.register(left_border_collider)
    collision_checker.register(right_border_collider)
    collision_checker.register(bottom_border_collider)
    collision_checker.register(top_border_collider)

    """Brick Instantiation"""
    normal_brick_factory = bricks.NormalBrickFactory(screen, collision_checker)
    cover_screen_brick_factory = bricks.CoverScreenBrickFactory(screen, normal_brick_factory)
    destroyed_bricks = bricks.DestroyedBricks(collision_checker, score)
    current_bricks = bricks.CurrentBricks(destroyed_bricks, state_manager)
    current_bricks.set_bricks(cover_screen_brick_factory.create(current_bricks))
    destroyed_bricks.change_bricks(current_bricks)
    win_state.destroyed_brick_mediator = destroyed_bricks
    lose_state.destroyed_brick_mediator = destroyed_bricks

    """Frame Based Events"""
    while running:
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                running = False

            pos = pygame.mouse.get_pos()
            rect = state_button.image.get_rect(x=state_button_position.x, y=state_button_position.y)

            # Check if rectangle collided with pos and if the left mouse button was pressed
            if rect.collidepoint(pos) and event.type == pygame.MOUSEBUTTONUP:
                if state_manager.state == play_state:
                    state_manager.pause()
                else:
                    state_manager.play()

        screen.fill("black")

        collision_checker.check()

        ball.draw(dt)
        slider.draw(dt)
        # slider2.draw(dt)

        for index, brick in enumerate(current_bricks.bricks):
            brick.draw(dt)

        text.draw(text_position)

        hud_background.draw(dt)
        hud_outline.draw(dt)

        lives.draw(dt)
        state_button.draw(dt)
        score.draw(dt)

        pygame.display.flip()

        dt = clock.tick(60) / 1000

    pygame.quit()
