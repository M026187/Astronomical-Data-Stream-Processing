// Frank Padovan, Astronomical Processing, Sprint 2
// Date: 11/05/25
// Version: 2.0
// Astronomical Data Stream Processing
// A forms based GUI application which displays recorded neutrino interactions per hour as an integer value for a 24 hour period.
// Data is displayed in a list box and uses text boxes for user input and for displaying messages. Buttons are used for data processing.
// Data processing includes the ability to load, view, sort, search and edit the neutrino interaction data set.
// There are also math functions which can be performed on the neutrino interaction data, including Mid-Extreme, Mode, Average and Range.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        int[] neutrinoInteractions = new int[arraySize];
        int listBoxSelection;
        int target = 0;
        int min = 0;
        int max = arraySize - 1;
        int maxCount;
        
        #region Average button click
        // Method to handle Average button click
        private void ButtonAverage_Click(object sender, EventArgs e)
        {
            // Check to see if data has been loaded
            if (CheckIfEmpty() == false)
            {
                // Calculate the Average value of neutrinoInteractions data
                MathAverage();
            } 
        }
        #endregion
        #region Binary Search button click
        // Method to handle Binary Search button click
        private void ButtonBinarySearch_Click(object sender, EventArgs e)
        {
            // Clear the Message text box
            TextBoxMessage.Clear();
            // Check to see if data has been loaded
            if (CheckIfEmpty())
            {
                // If empty then return
                return;
            }
            // Check to see if the user input is acceptable
            if (TestInput() == false)
            {
                // If user input is not acceptable then return
                return;
            }
            // Perform Binary Search
            List<int> result = SearchBinary(neutrinoInteractions, target);
            // If the search target is found, display to the user in the Message text box
            if (result.Count > 0)
            {
                TextBoxMessage.Text = target + " found at index " + string.Join(", ", result) + " using Binary Search";
                // Clear the Input text box
                TextBoxInput.Clear();
                // Give focus to the Input text box
                TextBoxInput.Focus();
            }
            // If the search target is not found, then display error to user
            else
            {
                TextBoxMessage.Text = "ERROR:" + "\r\n" + "Search value does not exist.";
                // Clear the Input text box
                TextBoxInput.Clear();
                // Give focus to the Input text box
                TextBoxInput.Focus();
            }
        }
        #endregion
        #region Edit button click
        // Method to deal with edit button being clicked
        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            // Clear the Message text box
            TextBoxMessage.Clear();
            // Check to see if the neutrino data has been loaded
            if (CheckIfEmpty())
            {
                // If neutrino data has not been loaded then return
                return;
            }
            // Check if a value has been selected in the list box
            if (ListBoxSelection())
            {
                // Check to see if data entered into Input text box is valid
                try
                {
                    // Convert the user input value to an integer and copy it to the neutrinoInteractions array
                    neutrinoInteractions[listBoxSelection] = Convert.ToInt32(TextBoxInput.Text);
                    // Inform the user which index has been edited
                    TextBoxMessage.Text = "Value edited at index: " + listBoxSelection + "\r\n";
                }
                // If it's not valid, then display error to user
                catch
                {
                    TextBoxMessage.Text = "ERROR:" + "\r\n" + "No valid input data" + "\r\n\r\n" + "Enter integer value into input";
                }
                // Display the edited value in the list box
                DisplayData();
            }
            // If a value hasn't been selected in the list box, display error to user
            else if (ListBoxSelection() == false)
            {
                TextBoxMessage.Text = "ERROR:" + "\r\n" + "Value to edit not selected" + "\r\n\r\n" + "Select value to edit";
            }
            // Clear user selection in list box
            ListBoxData.ClearSelected();
        }
        #endregion
        #region Load Data button click
        // Method to handle Load Data button click
        private void ButtonLoadData_Click(object sender, EventArgs e)
        {
            // Clear message display
            TextBoxMessage.Clear();
            // Load data into neutrinoInteractions array
            FillArray();
            // Inform the user that the data is loaded
            TextBoxMessage.Text = "Neutrino Data loaded";
        }
        #endregion
        #region Mid-Extreme button click
        // Method to handle Mid-Extreme button click
        private void ButtonMidExtreme_Click(object sender, EventArgs e)
        {
            // Check to see if data has been loaded
            if (CheckIfEmpty() == false)
            {
                // Sort data
                BubbleSort();
                // Calculate the Mid-Extreme value
                MathMidExtreme();
            }
        }
        #endregion
        #region Mode button click
        // Method to handle Mode button click
        private void ButtonMode_Click(object sender, EventArgs e)
        {
            // Check to see if data has been loaded
            if (CheckIfEmpty() == false)
            {
                // Calculate the Mode and return as a list called modes
                List<int> modes = MathMode(neutrinoInteractions);
                // Clear the Message text box
                TextBoxMessage.Clear();
                // Display the contents of the list modes to the Message text box
                TextBoxMessage.Text = "Mode: " + string.Join(", ", modes) + "\r\n\r\n" + "Occurrence: " + maxCount;
            }
        }
        #endregion
        #region Range button click
        // Method to handle Range button click
        private void ButtonRange_Click(object sender, EventArgs e)
        {
            // Check to see if data has been loaded
            if (CheckIfEmpty() == false)
            {
                // Sort neutrinoInteractions data
                BubbleSort();
                // Calculate the Range of neutrinoInteractions data
                MathRange();
            }  
        }
        #endregion
        #region Sequential Search button click
        // Method to handle Sequential Search button click
        private void ButtonSequentialSearch_Click(object sender, EventArgs e)
        {
            // Clear Message text box
            TextBoxMessage.Clear();
            // Check to see if data has been loaded
            if (CheckIfEmpty())
            {
                // If data has not been loaded, then return
                return;
            }
            // Check to see if the user input is acceptable
            if (TestInput() == false)
            {
                // If the user input is not acceptable then return
                return;
            }
            // Perform Sequential Search
            List<int> searchSeqResult = SearchSequential(neutrinoInteractions, target);

            // Check to see if the search found any matches
            if (searchSeqResult.Count > 0)
            {
                // Display to the user that the search value has been found and at the index it was found
                TextBoxMessage.Text = target + " found at index " + string.Join(", ", searchSeqResult) + " using Sequential Search";
                // Clear the Input text box
                TextBoxInput.Clear();
                // Give focus to the Input text box
                TextBoxInput.Focus();
            }
            // If the search target is not found, then display error to user
            else
            {
                TextBoxMessage.Text = "ERROR:" + "\r\n" + "Search value does not exist.";
                // Clear the Input text box
                TextBoxInput.Clear();
                // Give focus to the Input text box
                TextBoxInput.Focus();
            }
        }
        #endregion
        #region Sort button click
        // Method to handle Sort button click
        private void ButtonSort_Click(object sender, EventArgs e)
        {
            // Clear the Message text box
            TextBoxMessage.Clear();
            // Check to see if data has been loaded
            if (CheckIfEmpty())
            {
                return;
            }
            // Perform Bubble Sort 
            BubbleSort();
            // Display sorted values in the list box
            DisplayData();
            // Inform user that the data is sorted
            TextBoxMessage.Text = "Neutrino Data sorted";
        }
        #endregion
        #region BubbleSort
        // Method to sort the data stored in neutrinoInteractions array using Bubble Sort
        private void BubbleSort()
        {
            // Initialise variables
            bool swapped;
            int temp;
            // do until no more swaps have taken place
            do
            {
                swapped = false;
                // For all elements of the neutrinoInteractions array
                for (int i = 0; i < arraySize - 1; i++)
                {
                    // Check to see if element i is less than element i+1
                    if (neutrinoInteractions[i] > neutrinoInteractions[i + 1])
                    {
                        // Swap element i with element i+1
                        temp = neutrinoInteractions[i];
                        neutrinoInteractions[i] = neutrinoInteractions[i + 1];
                        neutrinoInteractions[i + 1] = temp;
                        // Flag swapped
                        swapped = true;
                    }
                }
            }
            while (swapped == true);
        }
        #endregion
        #region CheckIfEmpty
        // Method to check if the neutrinoInteractions array has been populated with neutrino interaction values
        private bool CheckIfEmpty()
        {
            // Initalise variables
            bool allZero = true;
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
            // If the data is empty prompt user to load data first
            if (allZero == true)
            {
                // Display ERROR to user in the Message text box
                TextBoxMessage.Text = "ERROR:" + "\r\n" + "No data loaded" + "\r\n\r\n" + "Load data to perform function";
            }
            // Return the result of checking the neutrinoInteractions array to see if it has been populated
            return allZero;
        }
        #endregion
        #region DisplayData
        // Method to display the contents of neutrinoInteractions array in the list box
        private void DisplayData()
        {
            // Clear list box
            ListBoxData.Items.Clear();
            // Display each element of neutrinoInteractions
            for (int x = 0; x < arraySize; x++)
            {
                // Display the value of neutrinoInteractions at the current index in the List Box
                ListBoxData.Items.Add(" " + neutrinoInteractions[x]);
            }
        }
        #endregion
        #region FillArray
        // Method to fill the neutrinoInteractions array with random values from 10 to 90
        private void FillArray()
        {
            // Create a new instance of the Random class used to generate pseudo-random numbers
            Random rand = new Random();
            // Fill the array with random numbers between 10 and 90
            for (int x = 0; x < arraySize; x++)
            {
                // Generate a random number between 10 and 90
                int randomInteger = rand.Next(10, 90);
                // Store the random number at the current index
                neutrinoInteractions[x] = randomInteger;
            }
            // Display contents of neutrinoInteractions in the list box
            DisplayData();
        }
        #endregion
        #region ListBoxSelection
        // Method to check if a list box element has been selected
        private bool ListBoxSelection()
        {
            // Initialise variables
            bool listBoxSelected = false;
            // Check the entire list box to see if any element has been selected
            for (int x = 0; x < arraySize; x++)
            {   
                // Check which list box element has been selected
                if (ListBoxData.GetSelected(x))
                {
                    // Record the index value that has been selected
                    listBoxSelection = x;
                    // As something has been selected, listBoxSelected becomes true
                    listBoxSelected = true;
                }
            }
            // Return the result of checking if an element has been selected
            return listBoxSelected;
        }
        #endregion
        #region MathAverage
        // Method to calculate the average of the neutrinoInteractions array
        private void MathAverage()
        {
            // Initialise variables
            double total = 0;
            double average;
            // Add all values in neutrinoInteractions
            foreach (int value in neutrinoInteractions)
            {
                total = total + value;
            }
            // Average by dividing the total by the number of array elements
            average = total / arraySize;
            // Display the Average to the Message text box
            TextBoxMessage.Text = "Average: " + average.ToString("0.00");
        }
        #endregion
        #region MathMidExtreme
        // Method to find the Mid-Extreme of the neutrinoInteractions array
        private void MathMidExtreme()
        {
            // Calculate the Mid-Extreme value
            double midExtreme = ((double)neutrinoInteractions[max] + (double)neutrinoInteractions[min]) / 2;
            // Display the Mid-Extreme value to the Message text box
            TextBoxMessage.Text = "Mid-Extreme: " + midExtreme.ToString("0.00");
        }
        #endregion
        #region MathMode
        // Method to find the Mode of the neutrinoInteractions array
        private List<int> MathMode(int[] arrayMode)
        {
            // Initialise Variables
            int arrayModeLength = arrayMode.Length;
            maxCount = 0;
            // Create a list to store all mode values
            List<int> modes = new List<int>();

            // Count the instances of each element
            for (int i = 0; i < arrayModeLength; i++)
            {
                int count = 0;

                // Compare each element with all other elements to find how many times it appears
                for (int j = 0; j < arrayModeLength; j++)
                {
                    if (arrayMode[i] == arrayMode[j])
                    {
                        // If an instance of the element is found keep track of the count
                        count++;
                    }
                }

                // If the count is greater than the current max then update
                if (count > maxCount)
                {
                    // Update the maxCount with the new max value
                    maxCount = count;
                    // Clear previous values
                    modes.Clear();
                    // Add the new mode to the mode value list
                    modes.Add(arrayMode[i]);
                }
                // If the count is equal to the current max count then check if mode value exists in the list. If not then add it to the mode value list
                else if (count == maxCount && !modes.Contains(arrayMode[i]))
                {
                    // Add the additional mode to the mode value list
                    modes.Add(arrayMode[i]);   
                }
            }
            // Return the result of the modes found
            return modes;
        }
        #endregion
        #region MathRange
        // Method to calculate the range of the neutrinoInteractions array
        private void MathRange()
        {
            // Calculate the range of neutrinoInteractions data
            double range = neutrinoInteractions[max] - neutrinoInteractions[min];
            // Display the range to the Message text box
            TextBoxMessage.Text = "Range: " + range.ToString("0.00");
        }
        #endregion
        #region SearchBinary
        // Method to search the data stored in neutrinoInteractions array using Binary Search
        private List<int> SearchBinary(int[] searchBinArray, int target)
        {
            // Initialise variables
            int min = 0;
            int max = searchBinArray.Length - 1;
            // Create a list to store search result indicies
            List<int> searchBinIndices = new List<int>();

            // Search until reaching either end of the array
            while (min <= max)
            {
                // Calculate the mid value to search against
                int mid = min + (max - min) / 2;

                // Check to see if the mid value equals the search value
                if (searchBinArray[mid] == target)
                {
                    // Search value has been found, check to see if there are further matches left and right of this instance
                    int i = mid;
                    // Search to the left until reaching the end
                    while (i >= 0 && searchBinArray[i] == target)
                    {
                        // Add the found value indicies to search result list
                        searchBinIndices.Add(i);
                        i--;
                    }
                    // Search to the right until reaching the end
                    i = mid + 1;
                    while (i < searchBinArray.Length && searchBinArray[i] == target)
                    {
                        // Add the found value indicies to search result list
                        searchBinIndices.Add(i);
                        i++;
                    }
                    break;
                }
                // If the mid value is less than the search value, then continue to search to the right of the array
                else if (searchBinArray[mid] < target)
                {
                    min = mid + 1;
                }
                // If the mid value is more than the search value, then continue to search to the left of the array
                else
                {
                    max = mid - 1;
                }
            }
            // Sort the found indicies
            searchBinIndices.Sort();
            // Return the search results
            return searchBinIndices;
        }
        #endregion
        #region SearchSequential
        // Method to search the data stored in the neutrinoInteractions array using Sequential Search
        private List<int> SearchSequential(int[] searchSeqArray, int target)
        {
            // Initialise variables
            int max = searchSeqArray.Length -1;
            // Create a new list to store the search result indicies
            List<int> searchSeqIndicies = new List<int>();
            
            // Compare the user input value with each element of neutrinoInteractions
            for (int i = 0; i <= max; i++)
            {
                // Check to see if the user input value is equal to the element of the array
                if (target == searchSeqArray[i])
                {
                    // if the user input value is found, then add the index where it was found to the search result list
                    searchSeqIndicies.Add(i);
                }
            }
            // Return the list of indexes that the user value was found at
            return searchSeqIndicies;  
        }
        #endregion
        #region TestInput
        // Method to test if the user input is an integer value
        private bool TestInput()
        {
            // Initialise variables
            bool testTarget = false;
            // Check to makes sure user has input an integer value into the Input text box
            try
            {
                // Convert user input to integer
                target = Convert.ToInt32(TextBoxInput.Text);
                // Conversion is successful
                testTarget = true;
                // Return conversion result
                return testTarget;
            }
            // If the user has not input an integer value into the Input text box, then display error in Message text box
            catch
            {
                // Display ERROR to user in the Message text box
                TextBoxMessage.Text = "ERROR:" + "\r\n" + "No input data to search for" + "\r\n\r\n" + "Enter an integer value to search";
                // Conversion is not successful
                testTarget = false;
                // Return conversion result
                return testTarget;
            }
        }
        #endregion
    }
}
