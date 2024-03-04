// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
// Get the Expense and Income radio buttons
const expenseButton = document.getElementById("radioleft");
const incomeButton = document.getElementById("radiomiddle");

// Get the Expense and Income labels
const expenseLabel = document.querySelector('label[for="radioleft"]');
const incomeLabel = document.querySelector('label[for="radiomiddle"]');

// Add click event listeners to the radio buttons
expenseButton.addEventListener("click", function () {
    expenseLabel.style.backgroundColor = "red"; // Change color to green
    incomeLabel.style.backgroundColor = ""; // Reset color for Income button
});

incomeButton.addEventListener("click", function () {
    incomeLabel.style.backgroundColor = "green"; // Change color to blue
    expenseLabel.style.backgroundColor = ""; // Reset color for Expense button
});

