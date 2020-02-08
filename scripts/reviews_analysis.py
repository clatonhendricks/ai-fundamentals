def analyze_reviews(text_analytics_client, reviews):

    # Use the Text Analytics service to analyze key phrases and sentiment
    key_phrase_analysis = text_analytics_client.key_phrases(documents=reviews)
    sentiment_analysis = text_analytics_client.sentiment(documents=reviews)

    # Print the results for each review
    for review_num in range(len(reviews)):
        # Get the sentiment score for this review
        sentiment_score = sentiment_analysis.documents[review_num].score
        if sentiment_score < 0.5:
            sentiment = 'negative'
        else:
            sentiment = 'positive'

        # print file name and sentiment
        print('-------------\n', reviews[review_num]['id'], '({})'.format(sentiment))

        # print review text
        print('\nText:', reviews[review_num]['text'])

        # Get the key phrases in this review
        print('\nKey Phrases:')
        key_phrases = key_phrase_analysis.documents[review_num].key_phrases
        for key_phrase in key_phrases:
            print('\t', key_phrase)
        print('\n')

