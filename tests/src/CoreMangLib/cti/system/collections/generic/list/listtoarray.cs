using System;
using System.Collections.Generic;
using System.Collections;
/// <summary>
///ToArray
/// </summary>
public class ListToArray
{
    public static int Main()
    {
        ListToArray ListToArray = new ListToArray();
        TestLibrary.TestFramework.BeginTestCase("ListToArray");
        if (ListToArray.RunTests())
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("PASS");
            return 100;
        }
        else
        {
            TestLibrary.TestFramework.EndTestCase();
            TestLibrary.TestFramework.LogInformation("FAIL");
            return 0;
        }
    }
    public bool RunTests()
    {
        bool retVal = true;
        TestLibrary.TestFramework.LogInformation("[Positive]");
        retVal = PosTest1() && retVal;
        retVal = PosTest2() && retVal;
        return retVal;
    }
    // Returns true if the expected result is right
    // Returns false if the expected result is wrong

    public bool PosTest1()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest1: Calling ToArray method of List,T is Value type.");
        try
        {
            List<int> myList = new List<int>();
            int count = 10;
            
            int element = 0;
            for (int i = 1; i <= count; i++)
            {
                element = i * count;
                myList.Add(element);
            }
            int[] actualArray=myList.ToArray();
            for (int j = 0; j < myList.Count; j++)
            {
                int current = (int)myList[j];
                if (actualArray[j] != current)
                {
                    TestLibrary.TestFramework.LogError("001.1." + j.ToString(), " current value should be " + actualArray[j]);
                    retVal = false;
                }

            }

        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("001.0", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }
    public bool PosTest2()
    {
        bool retVal = true;
        TestLibrary.TestFramework.BeginScenario("PosTest2: Calling ToArray method of List,T is reference type.");
        try
        {
            List<string> myList = new List<string>();
            int count = 10;
            string element = string.Empty;
            for (int i = 1; i <= count; i++)
            {
                element = i.ToString();
                myList.Add(element);
            }
            string [] actualArray = myList.ToArray();
            for (int j = 0; j < myList.Count; j++)
            {
                string current = (string)myList[j];
                if (actualArray[j] != current)
                {
                    TestLibrary.TestFramework.LogError("002.1." + j.ToString(), " current value should be " + actualArray[j]);
                    retVal = false;
                }

            }
        }
        catch (Exception e)
        {
            TestLibrary.TestFramework.LogError("002.0", "Unexpected exception: " + e);
            retVal = false;
        }

        return retVal;
    }

  

}

