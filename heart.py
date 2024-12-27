from PIL import Image, ImageDraw, ImageFont

# Create a blank image with white background
width, height = 300, 300
image = Image.new("RGB", (width, height), "white")
draw = ImageDraw.Draw(image)

# Draw a navy blue heart shape
heart_color = (0, 0, 128)  # Navy blue
draw.polygon([(150, 50), (200, 100), (150, 200), (100, 100)], fill=heart_color)

# Draw the upper half circles of the heart
draw.ellipse((100, 50, 150, 100), fill=heart_color)
draw.ellipse((150, 50, 200, 100), fill=heart_color)

# Add text
text = "ur my favorite person"
try:
    # Attempt to load a nice font if available
    font = ImageFont.truetype("arial.ttf", 15)
except IOError:
    font = ImageFont.load_default()  # Use default font if specified font is unavailable

# Calculate text width and position it in the center
text_width, text_height = draw.textsize(text, font=font)
text_x = (width - text_width) // 2
text_y = height - text_height - 20  # Position text near the bottom
draw.text((text_x, text_y), text, fill="black", font=font)

# Show the image
image.show()
