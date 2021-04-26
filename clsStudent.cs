using System.Collections.Generic;

namespace SampleBU07
{
    // Container class that represents a single student, storing ID, name and score information
    // used by the hosting application.
    public class clsStudent
    {
        #region clsStudent :: Class Declarations
        /// <summary>
        /// Arbitrary student ID assignment.
        /// </summary>
        public string StudentID { get; set; }
        // ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ 
        /// <summary>
        /// Arbitrary student first name or initial assignment.
        /// </summary>
        public string FName { get; set; }
        // ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ 
        /// <summary>
        /// Arbitrary student last name assignment.
        /// </summary>
        public string LName { get; set; }
        // ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ ─ 
        /// <summary>
        /// Average score of all non-zero scores.
        /// </summary>
        public double AverageScores
        {
            get { return AvgScores(); }
        }
        #endregion


        #region clsStudent :: Class Properties
        /// <summary>
        /// Property representing array for storing up to 5 scores for the student.
        /// </summary>
        private int[] scores = new int[5];
        public int[] Scores
        {
            get { return scores; }
            set { scores = value; }
        }
        #endregion


        #region clsStudent :: Class Constructors
        /// <summary>
        /// Default class constructor.
        /// </summary>
        public clsStudent()
        {
        }
        // ────────────────────────────────────────────────────────────────────────────────────────
        /// <summary>
        /// Class constructor with supplied student info only.
        /// </summary>
        /// <param name="pID">Student ID.</param>
        /// <param name="pFName">Student's first initial or name.</param>
        /// <param name="pLName">Student's last or name.</param>
        public clsStudent(string pID, string pFName, string pLName)
        {
            StudentID = pID;
            FName = pFName;
            LName = pLName;
        }
        // ────────────────────────────────────────────────────────────────────────────────────────
        /// <summary>
        /// Class constructor with supplied student info and scores.
        /// </summary>
        /// <param name="pID">Student ID.</param>
        /// <param name="pFName">Student's first initial or name.</param>
        /// <param name="pLName">Student's last or name.</param>
        /// <param name="pS1">Student score 1.</param>
        /// <param name="pS2">Student score 2.</param>
        /// <param name="pS3">Student score 3.</param>
        /// <param name="pS4">Student score 4.</param>
        /// <param name="pS5">Student score 5.</param>
        public clsStudent(string pID, string pFName, string pLName, int pS1, int pS2, int pS3, int pS4, int pS5)
        {
            StudentID = pID;
            FName = pFName;
            LName = pLName;
            Scores[0] = pS1;
            Scores[1] = pS2;
            Scores[2] = pS3;
            Scores[3] = pS4;
            Scores[4] = pS5;
        }
        // ────────────────────────────────────────────────────────────────────────────────────────
        /// <summary>
        /// Simple one paramter constructor.
        /// </summary>
        /// <param name="pID">Student ID.</param>
        public clsStudent(string pID)
        {
            StudentID = pID;
        }
        #endregion


        #region FORMATTED OUTPUT ROUTINES
        /// <summary>
        /// Overriding the default 'ToString()' function for object and class types, to
        /// print a string for the current student record.
        /// </summary>
        /// <returns>Single string formatted with stuent's data.</returns>
        public override string ToString()
        {
            string result = string.Empty;

            result = StudentID + "\t" + LName + ", " + FName + "\t\tScore #1: " + Scores[0] + "\tScore #2: " + Scores[1] +
                 "\tScore #3: " + Scores[2] + "\tScore #4: " + Scores[3] + "\tScore #5: " + Scores[4];

            return result;
        }
        // ────────────────────────────────────────────────────────────────────────────────────────
        /// <summary>
        /// Function to return custom formatted output to the calling routine.
        /// </summary>
        /// <returns>Formatted, multi-line output representing the student's data.</returns>
        public string ToMultiLineString()
        {
            string result = string.Empty;

            result = "────────────────────────────────────────────────\n";
            result = result + StudentID + "\t" + LName + ", " + FName; // Student ID, last and first name
            result = result + "\n    Score #1: " + Scores[0];          //    Score #1
            result = result + "\n    Score #2: " + Scores[1];          //    Score #2
            result = result + "\n    Score #3: " + Scores[2];          //    Score #3
            result = result + "\n    Score #4: " + Scores[3];          //    Score #4
            result = result + "\n    Score #5: " + Scores[4];          //    Score #5
            result = result + "\n\n";

            return result;
        }
        #endregion


        #region clsStudent :: Local Utility Support Routines
        /// <summary>
        /// Utility function to return the average of the scores that are non-zero.
        /// </summary>
        /// <returns>Average of all non-zero scores.</returns>
        private double AvgScores()
        {
            double result = 0;     // The calculated result
            double theSum = 0;     // Total of all non-zero scores found
            int theCount = 0;      // Count of numbers found above zero

            // Search the array of scores for values greater than zero, and sum up as needed
            for (int xx = 0; xx < 5; xx++)
            {
                if (Scores[xx] > 0)
                {
                    theSum = theSum + Scores[xx];   // Keep a running total of the scores
                    theCount++;                     // Keep count of scores found
                }
            }

            // If any scores were found, calculate and store the average
            if (theCount > 0)
                result = (double)(theSum / theCount);

            // Function finished, return the result to the caller
            return result;
        }
        #endregion
    }
}
