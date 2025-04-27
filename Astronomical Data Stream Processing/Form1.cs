using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Frank Padovan, Astronomical Processing, Sprint 1
// Date: 21/04/25
// Astronomical Data Stream Processing
// A forms based GUI application which displays recorded neutrino interactions per hour as an integer value for a 24 hour period.
// Data is displayed in a list box and uses text boxes for user input and for displaying messages. Buttons are used for data processing.
// Data processing includes the ability to load, view, sort, search and edit the neutrino interaction data set.

namespace Astronomical_Data_Stream_Processing
{
    public partial class AstronomicalProcessingForm: Form
    {
        public AstronomicalProcessingForm()
        {
            InitializeComponent();
        }

        // Global variables
        static int arraySize = 24;
        private int[] neutrinoInteractions = new int[arraySize];
        int listBoxSelected;
        bool allZero = true;
        bool nothingSelected = true;
        Random rand = new Random();

        // Method to deal with edit button being clicked
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            // Clear the message text box
            TextBoxMessage.Clear();
            // Check to see if the neutrino data has been loaded
            CheckIfEmpty();
            // If the data is empty prompt user to load data first
            if (allZero == true)
            {
                TextBoxMessage.Text = "ERROR:" + "\r\n" + "No data loaded" + "\r\n\r\n" + "Load data to edit";
                return;
            }
            // Check if a value has been selected in the list box
            ListBoxSelection();
            if (nothingSelected == false)
            {
                // Check to see if data entered into input text box is valid
                try
                {
                    neutrinoInteractions[listBoxSelected] = Convert.ToInt32(TextBoxInput.Text);
                    // Inform the user which index has been edited
                    TextBoxMessage.Text = "Value edited at index: " + listBoxSelected + "\r\n";
                }
                // If it's not valid, display error to user
                catch
                {
                    TextBoxMessage.Text = "ERROR:" + "\r\n" + "No valid input data" + "\r\n\r\n" + "Enter integer value into input";
                }
                // Display the edited value in the list box
                DisplayData();   
            }
            // If a value hasn't been selected in the list box, display error to user
            else if (nothingSelected == true)
            {
                TextBoxMessage.Text = "ERROR:" + "\r\n" + "Value to edit not selected" + "\r\n\r\n" + "Select value to edit";
            }
            // Clear user selection in list box
            ListBoxData.ClearSelected();
            nothingSelected = true;
        }
        // Method to handle load data button click
        private void ButtonLoadData_Click(object sender, EventArgs e)
        {
            // Clear message display
            TextBoxMessage.Clear();
            // Load data into neutrinoInteractions array
            FillArray();
        }
        // Method to handle search button click
        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            // Clear message display
            TextBoxMessage.Clear();
            // Check to see if data has been loaded
            CheckIfEmpty();
            // If data has not been loaded, display error to user
            if (allZero == true)
            {
                TextBoxMessage.Text = "ERROR:" + "\r\n" + "No data loaded" + "\r\n\r\n" + "Load data to search";
                return;
            }
            // Perform binary search
            BinarySearch();
        }
        // Method to handle sort button click
        private void ButtonSort_Click(object sender, EventArgs e)
        {
            // Clear message display
            TextBoxMessage.Clear();
            // Check to see if data has been loaded
            CheckIfEmpty();
            // If data has not been loaded, display error to user
            if (allZero == true)
            {
                TextBoxMessage.Text = "ERROR:" + "\r\n" + "No data loaded" + "\r\n\r\n" + "Load data to sort";
                return;
            }
            // Perform bubble sort 
            BubbleSort();
            // Display sorted values in the list box
            DisplayData();
        }

        private void ListBoxData_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxMessage_TextChanged(object sender, EventArgs e)
        {
        
        }
        // Method to search the data stored in neutrinoInteractions using binary search
        private void BinarySearch()
        {
            // Initialise variables
            int min = 0;
            int max = arraySize - 1;
            int target;
            // Check to makes sure user has input an integer value into the input text box
            try
            {
                target = Convert.ToInt32(TextBoxInput.Text);
            }
            // If the user has not input an integer value into the input text box, display error in message box
            catch
            {
                TextBoxMessage.Text = "ERROR:" + "\r\n" + "No input data to search for" + "\r\n\r\n" + "Enter an integer value to search";
                return;
            }
                     
            while (min <= max)
            {
                // Calculate the middle value of the neutrinoInteractions array
                int mid = (min + max) / 2;
                // Check to see if the search target matches the middle value of the neutrinoInteractions array
                if (target == neutrinoInteractions[mid])
                {
                    // If it matches then display to user that the search value has been found
                    TextBoxMessage.Text = target + " Found at index " + mid + "\r\n";
                    // Clear the input text box
                    TextBoxInput.Clear();
                    return;
                }
                // If the search target is less than the middle value then adjust the max value to be the previously calculated middle value - 1
                else if (target < neutrinoInteractions[mid])
                {
                    max = mid - 1;
                }
                // If the search target is greater than the middle value then adjust the min value to be the previously calculated middle value + 1
                else
                {
                    min = mid + 1;
                }
            }
            // If the search target is not found, display error to user
            TextBoxMessage.Text = "ERROR:" + "\r\n" + "Search value does not exist.";
            // Clear the input text box
            TextBoxInput.Clear();
            // Give focus to the input text box
            TextBoxInput.Focus();
        }
        // Method to sort the data stored in neutrinoInteractions using bubble sort
        private void BubbleSort()
        {
            // Initialise variables
            bool swapped;
            int temp;

            // do until swapped is true
            do
            {
                swapped = false;
                // For all elements of the neutrinoInteractions array
                for (int k = 0; k < arraySize - 1; k++)
                {
                    // Check to see if element k is less than element k+1
                    if (neutrinoInteractions[k] > neutrinoInteractions[k + 1])
                    {
                        // Swap element k with element k+1
                        temp = neutrinoInteractions[k];
                        neutrinoInteractions[k] = neutrinoInteractions[k + 1];
                        neutrinoInteractions[k + 1] = temp;
                        // Flag swapped
                        swapped = true;
                    }
                }
            }
            while (swapped == true);
        }
        // Method to check if the neutrinoInteractions array has been populated with neutrino interaction values
        private void CheckIfEmpty()
        {
            // Check each element in array
            foreach (int value in neutrinoInteractions)
            {   
                // Is the element non-zero
                if (value != 0)
                {
                    // Set allZero to false
                    allZero = false;
                    break;
                }
            }
        }
        // Method to display the contents of neutrinoInteractions in the list box
        private void DisplayData()
        {
            // Clear list box
            ListBoxData.Items.Clear();
            // Display each element of neutrinoInteractions
            for (int x = 0; x < arraySize; x++)
            {
                ListBoxData.Items.Add(" " + neutrinoInteractions[x]);
            }
        }
        // Method to fill the neutrinoInteractions array with random values from 10 to 90
        private void FillArray()
        {
            for (int x = 0; x < arraySize; x++)
            {
                for (int y = 0; y < arraySize;  y++)
                {
                    int randomInteger = rand.Next(10, 90);
                    // Check to see if new random number is a duplicate. If it is then regenerate, otherwise store in neutrinoInteractions
                    if (neutrinoInteractions.Contains(randomInteger))
                    {
                        y--;
                    }
                    else
                    {
                        neutrinoInteractions[y] = randomInteger;
                    }
                }
            }
            // Display contents of neutrinoInteractions in the list box
            DisplayData();
        }
        // Method to check if a list box element has been selected
        private void ListBoxSelection()
        {
            // Check the entire array to see if any items have been selected
            for (int x = 0; x < arraySize; x++)
            {   
                // Check which array elemnent has been selected
                if (ListBoxData.GetSelected(x))
                {
                    // Record the index value that has been selected
                    listBoxSelected = x;
                    // As something has been selected, nothingSelected becomes false
                    nothingSelected = false;
                }
            }
        }
    }
}
