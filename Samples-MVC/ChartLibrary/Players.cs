using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChartLibrary
{
        public class Players
        {
            
        /// get and set the PlayerId  
        /// </summary>  
            public int PlayerId
            {
                get;
                set;
            }
            /// <summary>  
            /// get and set the PlayerName  
            /// </summary>  
            public string PlayerName
            {
                get;
                set;
            }
            /// <summary>  
            /// get and set the PlayerList  
            /// </summary>  
            public List<Players> PlayerList
            {
                get;
                set;
            }
            /// <summary>  
            /// get and set the PlayerRecordList  
            /// </summary>  
            public List<PlayerRecord> PlayerRecordList
            {
                get;
                set;
            }
        }
        public class PlayerRecord
        {   /// <summary>  
            /// get and set the PlayerId  
            /// </summary>  
            public int PlayerId
            {
                get;
                set;
            }
            /// <summary>  
            /// get and set the Year  
            /// </summary>  
            public int Year
            {
                get;
                set;
            }
            /// <summary>  
            /// get and set the TotalRun  
            /// </summary>  
            public int TotalRun
            {
                get;
                set;
            }
            /// <summary>  
            /// get and set the TotalWickets  
            /// </summary>  
            public int TotalWickets
            {
                get;
                set;
            }
            /// <summary>  
            /// get and set the ODIMatches  
            /// </summary>  
            public int ODIMatches
            {
                get;
                set;
            }
            /// <summary>  
            /// get and set the TestMatches  
            /// </summary>  
            public int TestMatches
            {
                get;
                set;
            }  
        
        
    }
}
