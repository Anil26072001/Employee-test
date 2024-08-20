$(document).ready(function () {


    $("#submit").on("click", function (e) {
        e.preventDefault(); // Prevent the default form submission

        // Create the employee object using the correct syntax
        var employee = {
            FirstName: $("#FirstName").val(), // Correct property assignment
            Age: $("#Age").val(),
            Phone: $("#phonenum").val(),
            Date: $("#Date").val(),
            Destination: $("#Destination").val(),
            Salary: $("#Salary").val(),
        };

        
        $.ajax({
            url: 'https://localhost:7050/api/EmpDetails/Postemployee',
            type: 'POST', // Ensure 'POST' is in uppercase
            contentType: 'application/json', // Specify the content type
            data: JSON.stringify(employee), // Convert the employee object to a JSON string
            success: function (result) {
                alert("Successfully submitted");
                window.location.href = '/EmployeeController/EmployeeList';
            },
            error: function (xhr, status, error) {
                console.error("Submission failed: ", status, error);
            }
        });
    });



});