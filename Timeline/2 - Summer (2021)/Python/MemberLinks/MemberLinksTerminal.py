name = input("What is the streamer's name? ")  # Gets the streamers name

loop = ['YouTube', 'Twitch', 'DLive', 'Sliver', 'Twitter', 'Instagram', 'SnapChat', 'Facebook', 'Spotify', 'TikTok']

answer = ['', '', '', '', '', '', '', '', '', '']

loopNumber = 0

for i in loop:  # loop changes items in list answers to be used for late
    answer[loopNumber] = input(f"What is {name}'s {i}? ")  # uses loop so that the user knows which link it is asking for
    loopNumber += 1

print(f"\nUGN {name}")  # prints member link header

print(f"""GO CHECK OUT THE HOST OF THIS CONTENT / UGN {name} / SOCIAL LINKS BELOW 
🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 🔽 """)   # prints rest of header

loop2 = ['🔴 YOUTUBE | ', '🔴 TWITCH | ', '🔴 DLIVE | ', '🔴 SLIVER | ', '💻 TWITTER | ', '📲 INSTAGRAM | ', '📲 SNAPCHAT | ',
         '😜 FACEBOOK | ', '🎶SPOTIFY : ', '🕑 TIKTOK | ']  # rest of the lines put together the rest of link list

loopNumber = 0

for items in loop2:
    if answer[loopNumber] != "":
        print(items + answer[loopNumber])
    loopNumber += 1
