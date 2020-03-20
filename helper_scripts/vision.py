def show_image_caption(image_path, description):
    import matplotlib.pyplot as plt
    from PIL import Image

    # Display the image
    fig = plt.figure(figsize=(8, 8))
    img = Image.open(image_path)
    caption_text = ''
    if (len(description.captions) == 0):
        caption_text = 'No caption detected'
    else:
        for caption in description.captions:
            caption_text = caption_text + " '{}'\n(Confidence: {:.2f}%)".format(caption.text, caption.confidence * 100)
    plt.title(caption_text)
    plt.axis('off')
    plt.imshow(img)