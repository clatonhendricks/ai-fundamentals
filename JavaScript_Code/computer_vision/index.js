'use strict';

const async = require('async');
const fs = require('fs');
const path = require("path");
const createReadStream = require('fs').createReadStream
const sleep = require('util').promisify(setTimeout);
const ComputerVisionClient = require('@azure/cognitiveservices-computervision').ComputerVisionClient;
const ApiKeyCredentials = require('@azure/ms-rest-js').ApiKeyCredentials;

function computerVision() {
    async.series([
        async function () {
        },
        function () {
            return new Promise((resolve) => {
                resolve();
                /**
                * AUTHENTICATE
                * This single client is used for all examples.
                */
               
                let key = process.env['COMPUTER_VISION_SUBSCRIPTION_KEY'];
                let endpoint = process.env['COMPUTER_VISION_ENDPOINT']
                if (!key) { throw new Error('Set your environment variables for your subscription key and endpoint.'); }

                let computerVisionClient = new ComputerVisionClient(
                    new ApiKeyCredentials({ inHeader: { 'Ocp-Apim-Subscription-Key': key } }), endpoint);


                var describeURL = 'https://moderatorsampleimages.blob.core.windows.net/samples/sample1.jpg';

                // Analyze URL image
                console.log('Analyzing URL image to describe...', describeURL.split('/').pop());
                var caption = (await computerVisionClient.describeImage(describeURL)).captions[0];
                console.log(`This may be ${caption.text} (${caption.confidence.toFixed(2)} confidence)`);
            })
        }
    ], (err) => {
        throw (err);
    });
}


computerVision();   