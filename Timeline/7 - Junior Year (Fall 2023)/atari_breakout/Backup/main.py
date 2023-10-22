import pygame
import pygame.freetype
from entities import *
from physics import *
from hud import *
from shapes import *

if __name__ == '__main__':
    """GAME SETTINGS"""
    pygame.init()
    screen = pygame.display.set_mode((1280, 720))
    clock = pygame.time.Clock()
    running = True
    dt = 0
    GAME_FONT = pygame.freetype.Font('../atari_breakout/ARCADECLASSIC.TTF', 340)
    LOSE_FONT = pygame.freetype.Font('../atari_breakout/ARCADECLASSIC.TTF', 295)

    """Slider and ball settings"""
    player_pos = Position(screen.get_width() / 2 - 80, screen.get_height() / 2)
    velocity = Velocity(300, 300)

    slider_position = Position(screen.get_width() / 2 - 80, screen.get_height() / 2 + 90)

    circle = Circle(screen, "green", player_pos, 40)
    ball = Ball(circle, player_pos, velocity)
    slider_shape = Rectangle(screen, "red", slider_position, 160, 80)
    slider = Slider(slider_shape, slider_position)

    """Border Instantiation"""
    # slider2 = Slider(pygame, screen, "blue", [screen.get_width() / 2 - 80, screen.get_height() / 2 + 90], 80, 40)
    top_border = Border(Position(-300, -300), screen.get_width() + 600, 300)
    right_border = Border(Position(screen.get_width(), -300), 300, screen.get_height() + 600)
    bottom_border = Border(Position(-300, screen.get_height()), screen.get_width() + 600, 300)
    left_border = Border(Position(-300, -300), 300, screen.get_height() + 600)

    """Collision Checker Settings"""
    collision_checker = CollisionChecker()
    collision_checker.register(ball)
    collision_checker.register(slider)
    collision_checker.register(left_border)
    collision_checker.register(right_border)
    collision_checker.register(bottom_border)
    collision_checker.register(top_border)

    """HUD Instantiation"""
    hud_outline_shape = Rectangle(screen, "grey", Position(0, screen.get_height() / 4 * 3), screen.get_width(), 20)
    hud_bg_shape = Rectangle(screen, "black", Position(0, screen.get_height() / 4 * 3), screen.get_width(),
                             int(screen.get_height() / 4))
    hud_outline = Background(hud_outline_shape, Position(0, screen.get_height() / 4 * 3))
    hud_background = Background(hud_bg_shape, Position(0, screen.get_height() / 4 * 3))

    lives_position = Position(100, screen.get_height() / 4 * 3 + 100)
    lives_logo = Circle(screen, "green", lives_position, 40)
    lives_text = Text(screen, (255, 0, 0), lives_position, pygame.freetype.Font('../atari_breakout/ARCADECLASSIC.TTF', 100), "")
    lives = Lives(lives_logo, 3, screen, pygame.freetype.Font('../atari_breakout/ARCADECLASSIC.TTF', 100))

    """Brick Instantiation"""
    bricks = []
    y = 20
    for i in range(3):
        x = 20
        while x < screen.get_width():
            shape = Rectangle(screen, "blue", Position(x, y), 160, 80)
            brick = Brick(shape, Position(x, y))
            bricks.append(brick)
            collision_checker.register(brick)
            x += 180
        y += 100

    """Frame Based Events"""
    while running:
        for event in pygame.event.get():
            if event.type == pygame.QUIT:
                running = False

        screen.fill("black")

        collision_checker.check()

        ball.draw(dt)
        slider.draw(dt)
        # slider2.draw(dt)

        for index, brick in enumerate(bricks):
            if not brick.destroyed:
                brick.draw(dt)
            else:
                if brick in collision_checker.objects:
                    collision_checker.remove(brick)
                    del bricks[index]

        if len(bricks) == 0:
            text, rect = GAME_FONT.render("YOU WIN!", (255, 0, 0))
            screen.blit(text, (0, screen.get_height() / 3))
            ball.velocity.change(0, 0)

        if lives.lives == 0:
            text, rect = LOSE_FONT.render("YOU LOSE!", (255, 0, 0))
            screen.blit(text, (0, screen.get_height() / 3))
            ball.velocity.change(0, 0)
            ball.position.y = screen.get_height()

        elif ball in bottom_border.collider.collisions.keys():
            lives.lives -= 1
            ball.position.reset()
            ball.velocity.reset()
            slider.position.reset()

        hud_background.draw(dt)
        hud_outline.draw(dt)

        lives.draw(dt)

        pygame.display.flip()

        dt = clock.tick(60) / 1000

    pygame.quit()
