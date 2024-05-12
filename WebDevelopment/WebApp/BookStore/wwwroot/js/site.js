$(document).ready(function () {

    //DOM Selection     //Events
    $('#authorForm').submit(function (event) {
        // Prevent form submission
        event.preventDefault();

        // Custom validation for each field
        var name = $('#name').val().trim();
        var address = $('#address').val().trim();
        var email = $('#email').val().trim();
        var gender = $('#gender').val();
        var dob = $('#dob').val();

        var nameError = $('#nameError');
        var addressError = $('#addressError');
        var emailError = $('#emailError');
        var genderError = $('#genderError');
        var dobError = $('#dobError');

        var valid = true;

        // Validate Name
        if (name == '') {
            //DOM Manipulation
            nameError.text('Please enter your name');
            valid = false;
        } else {
            nameError.text('');
        }

        // Validate Address
        if (address == '') {
            addressError.text('Please enter your address');
            valid = false;
        } else {
            addressError.text('');
        }

        // Validate Email
        if (email == '') {
            emailError.text('Please enter your email address');
            valid = false;
        } else if (!isValidEmail(email)) {
            emailError.text('Please enter a valid email address');
            valid = false;
        } else {
            emailError.text('');
        }

        // Validate Gender
        if (gender == '') {
            genderError.text('Please select your gender');
            valid = false;
        } else {
            genderError.text('');
        }

        // Validate DOB
        if (dob == '') {
            dobError.text('Please enter your date of birth');
            valid = false;
        } else {
            dobError.text('');
        }

        // If all validations pass, submit the form
        if (valid) {
            this.submit();
        }
    });
});

// Function to validate email format
function isValidEmail(email) {
    var emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
    return emailRegex.test(email);
}


//AJAX
$('#authorForm').submit(function () {
    // Get form data
    var formData = {
        Name: $('#name').val(),
        Address: $('#address').val()
        // Add other form fields here
    };

    // Submit form data via AJAX
    $.ajax({
        type: 'POST',
        url: '/author/add', // Specify your server endpoint
        data: formData,
        dataType: 'json',
        encode: true
    })
        .done(function (data) {
            // Handle successful response
            console.log(data);
            // You can show a success message or redirect the user
        })
        .fail(function (data) {
            // Handle error response
            console.log(data);
            // You can display an error message or handle the error in another way
        });

});