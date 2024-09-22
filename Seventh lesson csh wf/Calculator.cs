using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seventh_lesson_csh_wf
{
    public class Calculator
    {
        public List<string> Text { get; set; }
        public List<bool> IsSign { get; set; }
        public bool IsSmaller { get; set; }

        public Calculator()
        {
            Text = new List<string>();
        }

        public void IsSignFunction()
        {
            if (Text.Count != 0)
            {
                IsSign = new List<bool>();
                for (int i = 0; i < Text.Count; i++)
                {
                    if (Text[i] == "+" || Text[i] == "-" || Text[i] == "*" || Text[i] == "/" || Text[i] == "%")
                        IsSign.Add(true);
                    else
                        IsSign.Add(false);
                }
            }
        }
        public string BeforeAndAfterSign()
        {
            for (int i = 0; i < Text.Count; i++)
            {
                if (IsSign[i] && (Text[i] == "*" || Text[i] == "/" || Text[i] == "%"))
                {
                    int numberIntBefore = 0, indexStart = 0;
                    string[] numbersStrBefore = new string[i];
                    bool isEndBefore = false;

                    for (int index = numbersStrBefore.Length - 1, j = 0; index >= 0; index--, j++)
                    {
                        if (!IsSign[index])
                        {
                            numbersStrBefore[j] = Text[index];
                            if (index > 0)
                            {
                                if (IsSign[index - 1])
                                {
                                    indexStart = index;
                                    isEndBefore = true;
                                    Array.Reverse(numbersStrBefore);
                                    string tmp = String.Join("", numbersStrBefore);
                                    numberIntBefore = Convert.ToInt32(tmp);
                                    break;
                                }
                            }
                            else
                            {
                                indexStart = index;
                                isEndBefore = true;
                                Array.Reverse(numbersStrBefore);
                                string tmp = String.Join("", numbersStrBefore);
                                numberIntBefore = Convert.ToInt32(tmp);
                                break;
                            }
                        }
                    }

                    int numberIntAfter = 0, indexFinish = 0;
                    string[] numbersStrAfter = new string[Text.Count - (i + 1)];
                    bool isEndAfter = false;
                    
                    for (int index = i + 1, j = 0; index < Text.Count; index++, j++)
                    {
                        if (!IsSign[index])
                        {
                            numbersStrAfter[j] = Text[index];
                            if (index < Text.Count - 1)
                            {
                                if (IsSign[index + 1])
                                {
                                    indexFinish = index + 1;
                                    isEndAfter = true;
                                    string tmp = String.Join("", numbersStrAfter);
                                    numberIntAfter = Convert.ToInt32(tmp);
                                    break;
                                }
                            }
                            else
                            {
                                indexFinish = index + 1;
                                isEndAfter = true;
                                string tmp = String.Join("", numbersStrAfter);
                                numberIntAfter = Convert.ToInt32(tmp);
                                break;
                            }
                        }
                    }

                    if (Text[i] == "*")
                    {
                        int res = numberIntBefore * numberIntAfter;
                        List<string> newText = new List<string>(Text.Count + 1);
                        string tmp = Convert.ToString(res);
                        string[] tmp2 = new string[] { tmp };
                        
                        for (int j = 0; j < indexStart; j++)
                            newText.Add(Text[j]);
                        for (int j = 0; j < tmp2.Length; j++)
                            newText.Add(tmp2[j]);
                        for (int j = indexFinish; j < Text.Count; j++)
                            newText.Add(Text[j]);

                        Text = newText;
                        i = indexStart;
                        IsSignFunction();
                    }
                    if (Text[i] == "/")
                    {
                        if (numberIntBefore < numberIntAfter)
                        {
                            IsSmaller = true;
                            return "0";
                        }

                        int res = numberIntBefore / numberIntAfter;
                        List<string> newText = new List<string>(Text.Count + 1);
                        string tmp = Convert.ToString(res);
                        string[] tmp2 = new string[] { tmp };
                        
                        for (int j = 0; j < indexStart; j++)
                            newText.Add(Text[j]);
                        for (int j = 0; j < tmp2.Length; j++)
                            newText.Add(tmp2[j]);
                        for (int j = indexFinish; j < Text.Count; j++)
                            newText.Add(Text[j]);
                        
                        Text = newText;
                        i = indexStart;
                        IsSignFunction();
                    }
                    if (Text[i] == "%")
                    {
                        if (numberIntBefore < numberIntAfter)
                        {
                            IsSmaller = true;
                            return "0";
                        }

                        int res = numberIntBefore % numberIntAfter;
                        List<string> newText = new List<string>(Text.Count + 1);
                        string tmp = Convert.ToString(res);
                        string[] tmp2 = new string[] { tmp };

                        for (int j = 0; j < indexStart; j++)
                            newText.Add(Text[j]);
                        for (int j = 0; j < tmp2.Length; j++)
                            newText.Add(tmp2[j]);
                        for (int j = indexFinish; j < Text.Count; j++)
                            newText.Add(Text[j]);

                        Text = newText;
                        i = indexStart;
                        IsSignFunction();
                    }
                }
            }

            for (int i = 0; i < Text.Count; i++)
            {
                if (IsSign[i] && (Text[i] == "+" || Text[i] == "-"))
                {
                    int numberIntBefore = 0, indexStart = 0;
                    string[] numbersStrBefore = new string[i];
                    bool isEndBefore = false;
                    for (int index = numbersStrBefore.Length - 1, j = 0; index >= 0; index--, j++)
                    {
                        if (!IsSign[index])
                        {
                            numbersStrBefore[j] = Text[index];
                            if (index > 0)
                            {
                                if (IsSign[index - 1])
                                {
                                    indexStart = index;
                                    isEndBefore = true;
                                    Array.Reverse(numbersStrBefore);
                                    string tmp = String.Join("", numbersStrBefore);
                                    numberIntBefore = Convert.ToInt32(tmp);
                                    break;
                                }
                            }
                            else
                            {
                                indexStart = index;
                                isEndBefore = true;
                                Array.Reverse(numbersStrBefore);
                                string tmp = String.Join("", numbersStrBefore);
                                numberIntBefore = Convert.ToInt32(tmp);
                                break;
                            }
                        }
                    }

                    int numberIntAfter = 0, indexFinish = 0;
                    string[] numbersStrAfter = new string[Text.Count - (i + 1)];
                    bool isEndAfter = false;

                    for (int index = i + 1, j = 0; index < Text.Count; index++, j++)
                    {
                        if (!IsSign[index])
                        {
                            numbersStrAfter[j] = Text[index];
                            if (index < Text.Count - 1)
                            {
                                if (IsSign[index + 1])
                                {
                                    indexFinish = index + 1;
                                    isEndAfter = true;
                                    string tmp = String.Join("", numbersStrAfter);
                                    numberIntAfter = Convert.ToInt32(tmp);
                                    break;
                                }
                            }
                            else
                            {
                                indexFinish = index + 1;
                                isEndAfter = true;
                                string tmp = String.Join("", numbersStrAfter);
                                numberIntAfter = Convert.ToInt32(tmp);
                                break;
                            }
                        }
                    }

                    if (Text[i] == "+")
                    {
                        int res = numberIntBefore + numberIntAfter;
                        List<string> newText = new List<string>(Text.Count + 1);
                        string tmp = Convert.ToString(res);
                        string[] tmp2 = new string[] { tmp };

                        for (int j = 0; j < indexStart; j++)
                            newText.Add(Text[j]);
                        for (int j = 0; j < tmp2.Length; j++)
                            newText.Add(tmp2[j]);
                        for (int j = indexFinish; j < Text.Count; j++)
                            newText.Add(Text[j]);
                        
                        Text = newText;
                        i = indexStart;
                        IsSignFunction();
                    }
                    if (Text[i] == "-")
                    {
                        if (numberIntBefore < numberIntAfter)
                        {
                            IsSmaller = true;
                            return "0";
                        }

                        int res = numberIntBefore - numberIntAfter;
                        List<string> newText = new List<string>(Text.Count + 1);
                        string tmp = Convert.ToString(res);
                        string[] tmp2 = new string[] { tmp };

                        for (int j = 0; j < indexStart; j++)
                            newText.Add(Text[j]);
                        for (int j = 0; j < tmp2.Length; j++)
                            newText.Add(tmp2[j]);
                        for (int j = indexFinish; j < Text.Count; j++)
                            newText.Add(Text[j]);

                        Text = newText;
                        i = indexStart;
                        IsSignFunction();
                    }
                }
            }
            return "0";
        }

        public override string ToString()
        {
            if (Text != null)
            {
                string tmp = "";
                for (int i = 0; i < Text.Count; i++)
                    tmp += Text[i];
                return tmp;
            }
            else
                return "\nEmpty!";
        }
    }
}
