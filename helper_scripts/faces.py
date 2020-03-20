def show_faces(image_path, detected_faces, show_id=False):
    import matplotlib.pyplot as plt
    from PIL import Image, ImageDraw

    # Open an image
    img = Image.open(image_path)

    # Create a figure to display the results
    fig = plt.figure(figsize=(8, 8))

    if detected_faces:
        # If there are faces, how many?
        num_faces = len(detected_faces)
        prediction = ' (' + str(num_faces) + ' faces detected)'
        # Draw a rectangle around each detected face
        for face in detected_faces:
            r = face.face_rectangle
            bounding_box = ((r.left, r.top), (r.left + r.width, r.top + r.height))
            draw = ImageDraw.Draw(img)
            draw.rectangle(bounding_box, outline='magenta', width=5)
            if show_id:
                plt.annotate(face.face_id,(r.left, r.top + r.height + 15), backgroundcolor='white')
            a = fig.add_subplot(1,1,1)
            a.set_title(prediction)

    plt.axis('off')
    plt.imshow(img)

def print_face_attributes(detected_faces):
    if detected_faces:
        for face in detected_faces:
            print('Face ID:', face.face_id)
            detected_attributes = face.face_attributes.as_dict()
            for attribute in detected_attributes:
                print('-{}:{}'.format(attribute, detected_attributes[attribute]))

def show_similar_faces(image_1_path, image_1_face, image_2_path, image_2_faces, similar_faces):
    import matplotlib.pyplot as plt
    from PIL import Image, ImageDraw

    # Create a figure to display the results
    fig = plt.figure(figsize=(16, 8))

    # Show face 1
    img1 = Image.open(image_1_path)
    r = image_1_face.face_rectangle
    bounding_box = ((r.left, r.top), (r.left + r.width, r.top + r.height))
    draw = ImageDraw.Draw(img1)
    draw.rectangle(bounding_box, outline='magenta', width=5)
    a = fig.add_subplot(1,2,1)
    plt.axis('off')
    plt.imshow(img1)

    # get the matching face IDs
    matching_face_ids = list(map(lambda face: face.face_id, similar_faces))

    # Draw a rectangle around each similar face in image 2
    img2 = Image.open(image_2_path)
    a = fig.add_subplot(1,2,2)
    plt.axis('off')
    for face in image_2_faces:
        r = face.face_rectangle
        bounding_box = ((r.left, r.top), (r.left + r.width, r.top + r.height))
        draw = ImageDraw.Draw(img2)
        if face.face_id in matching_face_ids:
            draw.rectangle(bounding_box, outline='lightgreen', width=10)
            plt.annotate('Match!',(r.left, r.top + r.height + 15), backgroundcolor='white')
        else:
            draw.rectangle(bounding_box, outline='red', width=5)
    plt.imshow(img2)
    plt.show()