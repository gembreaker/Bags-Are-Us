window.addEventListener("load", function () {

    // Create a change event handler for the product image file upload field
    document.getElementById("ProductImageFile").addEventListener("change", function (e) {

        // Call the CheckValidPosterExtension method passing the element that caused the change event (this)
        CheckValidPosterExtension(this);
    });

    // Method to check if poster upload files has valid file extension .jpg, .png, or .gif (you can add more if you wish)
    function CheckValidPosterExtension(poster) {
        // Create a regular expression with a string pattern checking for the following extensions at the end of the filename
        let re = /\.(jpg|png|gif)$/i;

        // Get the <span> element to display an error message for the this field i.e. the value of the data-valmsg-for attribute will be the ID value of the input field
        let errorField = document.querySelector("span[data-valmsg-for=" + poster.id + "]");

        // Reset the error message
        errorField.innerHTML = "";

        // Test the selected poster file to upload using the regular expression
        if (poster.value !== "" && !re.test(poster.value)) {
            // Does not match i.e. wrong extension type
            errorField.innerHTML = "Invalid file extension! Only .jpg, .png, or .gif allowed.";

            // Clear the file, don't allow upload
            poster.value = null;
            return false;
        }

        // Test okay, return true
        return true;
    }
});