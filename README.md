<h1><b>Steganography program</b></h1>
<img src="assets/test.jpg" width="500"></img>
<h4>Extract the text (1LSB) from this image and decrypt using symetric alongside this key: '23561287'. :)</h4>
<hr>
<p>This program takes a cover image and allows the user to store text OR an image inside of another image.</p>
<p>User can choose to modify 1/2/3/4 LSB (least significant bit(s)).<p> 
<p>1LSB means less potential storage but less noise (1/255) - 4LSB means more 4x more potential storage than 1LSB but 4x the noise (16/255)<p>
<p>Image embed is currently always set to 1LSB, the input image must be 8x smaller than the cover image.</p>
<p>I made a YouTube <a href="https://youtu.be/Bgl_wmb9dU0">demonstration</a> for this program but it is slightly outdated now, it's still the same concept though!</p>

<hr>
<h2>Instructions:</h2>
<p>Instructions can also be found in the program on the about form.</p>
<h4>Embedding</h4>
<p><i>NOTE: Symetric encryption ONLY works for 1 and 4 LSB.</i></p>
<ol>
<li>Open your cover image using the &quot;file&quot; section.</li>

<li>Add the text you would like to embed using the &quot;text to embed&quot; box.</li>

<li>Do you want to encrypt the text? if so type in a key and click encrypt.</li>

<li>You must select the amount of LSB you would like to use for the embedding process.</li>

<li>Click 'Embed'.</li>

<li>Click save in the 'stego image' section and select location and name of new stego image.</li>
</ol>

<hr>
<h4>Extracting</h4>
<p><i> NOTE: You will notice, if you saved your stego image in the current session, that the 'stego route' box is already filled with your new images directory location.</i></p>
<ol>
<li>Use the open button under the stego route to select the image you would like to extract a message from.</li>
<li>Select the apropriate amount of LSB which you used to embed the message.</li>
<li>Click &quot;Extract&quot;.</li>
<li>IF you encrypted the string, make sure the key is entered and correct encryption method is selected, click decrypt.</li>
</ol>

<hr>
<h4>Image embedding</h4>
<i> NOTE: This feature uses 1LSB steganography and therefore your input image must be 8x smaller than your cover image.</i>
<ol>
<li>Select your cover image.</li>
<li>Select the image you would like to embed.</li>
<hr>
<li>Click &quot;Embed&quot;.</li>
<li>Save your new stego image using the dialog available.</li>
</ol>

<hr>
<h4>Image extracting</h4>
<ol>
<li>Select target file (stego image).</li>
<li>Click &quot;Extract&quot;.</li>
<li>Save your extracted image.</li>
</ol>

<hr>
<h4>Comparison tool</h4>
<ol>
<li> Step 1: Load your first image using the dialog.</li>

<li>Step 2: Load your second image using the dialog.</li>

<li>Step 3: Click &quot;compare&quot;.</li>
</ol>
