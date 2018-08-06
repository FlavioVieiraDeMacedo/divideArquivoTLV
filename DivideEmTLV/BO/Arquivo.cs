using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DivideEmTLV.BO
{
    class Arquivo
    {
        public static List<string> ConfigTags = new List<string>();

        public void Break_TLV_File(string Texto, string FinalTag, string BeginTag, string AplicationLength1, string AplicationLength2, string savePath,string pathTag)
        {
            ConfigTags = LeArquivoTagConfig(pathTag);
            List<string> bytes = SliceInBytesWithCaracter(Texto, ' ');
            List<string> cards = Slice_Cards(bytes, FinalTag);
            var i = 0;
            foreach (var item in cards)
            {
                List<string> a = SliceInBytes(item);
                var card1 = SplitCard(a, AplicationLength1.Trim(), AplicationLength2.Trim(), BeginTag);
                EscreveArquivo(savePath, card1, i);
                i++;
            }

        }

        public string GetFileAndJoinTags(string Path)
        {
            string text = File.ReadAllText(Path, Encoding.Default);

            return text;
        }

        public string askToHex(string Content)
        {
            char[] chares = Content.ToCharArray();

            byte[] ba = Encoding.Default.GetBytes(Content);
            var hexString = BitConverter.ToString(ba);
            var a = "";
            foreach (var item in ba)
            {
                a += Int64.Parse(item.ToString()).ToString("X") + " ";
            }
            return hexString.Replace("-", " ");
        }

        public List<string> Slice_Cards(List<string> Bytes, string FinalTag)
        {
            List<string> TagsFinal = FinalTag.Split(' ').ToList();
            string aux = "";
            List<string> content = new List<string>();

            string last = "";
            foreach (var item in Bytes)
            {
                aux += item;
                if (item == TagsFinal[1] && last == TagsFinal[0])
                {
                    content.Add(aux);
                    aux = "";
                }
                last = item;
            }
            return content;
        }

        public List<string> SliceInBytesWithCaracter(string Content, char caractere)
        {
            List<string> bytes = Content.Split(caractere).ToList();
            var b = bytes.Last();
            return bytes;
        }

        public List<string> SliceInBytes(string Content)
        {
            var aux = false;
            var Byte = "";
            char[] Nibble = Content.ToCharArray();
            List<string> Bytes = new List<string>();
            foreach (var item in Content)
            {
                if (aux)
                {
                    Byte += item.ToString();
                    Bytes.Add(Byte);
                    aux = false;
                }
                else
                {
                    Byte = item.ToString();
                    aux = true;
                }
            }
            return Bytes;
        }

        public string SplitCard(List<string> Card, string Hexa_Length_Aplication1, string Hexa_Length_Aplication2, string beginTag)
        {
            bool aux = false;
            var isTagByte = true;
            var TotalContent = "";
            var Count = 0;
            var DecLength = 0;
            var TagMaisBytes = 0;
            var aplication1_length = int.Parse(Hexa_Length_Aplication1.Replace(" ",""), System.Globalization.NumberStyles.HexNumber);
            var aplication2_length = int.Parse(Hexa_Length_Aplication2.Replace(" ", ""), System.Globalization.NumberStyles.HexNumber);

            for (int i = 0; i < Card.Count; i++)
            {
                #region pega antes do 01 01 DB
                if (i < Card.Count - 3)
                {
                    if (Card[i + 1] == beginTag.Split(' ')[0] && Card[i + 2] == beginTag.Split(' ')[1] && Card[i + 3] == beginTag.Split(' ')[2])
                    {
                        TotalContent += "\r\n";
                        aux = true;
                        TotalContent += Card[i + 1] + " " + Card[i + 2] + " " + Card[i + 3];
                        i += 4;
                    }
                }
                #endregion

                #region pega depois do 01 01 DB


                if (aux && aplication1_length > 0)
                {
                    if (isTagByte)
                    {
                        var Tag = Card[i];
                        TagMaisBytes = VerifyTagAMais(Card[i], Card[i + 1], Card[i + 2]);
                        var a = Card[i + 1 + TagMaisBytes];
                        DecLength = int.Parse(Card[i + 1 + TagMaisBytes], System.Globalization.NumberStyles.HexNumber);
                        TotalContent += "\r\n";
                        isTagByte = false;
                    }
                    else
                    {
                        if (Count == DecLength + TagMaisBytes)
                        {
                            isTagByte = true;
                            Count = 0;
                        }
                        else
                        {
                            Count++;
                        }
                    }

                    aplication1_length--;
                }
                #endregion

                #region pega antes do 01 F5

                if (i < Card.Count - 3)
                {
                    if (aplication1_length < 0)
                    {
                        var a1 = Card[i + 1];
                        var b1 = Card[i + 2];
                        if (Card[i + 1] == Hexa_Length_Aplication2.Split(' ')[0] && Card[i + 2] == Hexa_Length_Aplication2.Split(' ')[1])
                        {
                            TotalContent += "\r\n --debito-- \r\n";
                            aux = true;
                            TotalContent += Card[i] + " " + Card[i + 1] + " " + Card[i + 2] + " ";
                            i += 3;
                        }
                    }
                }

                #endregion

                #region pega depois do 01 01 DB

                if (aux && aplication1_length < 0 && aplication2_length > 0)
                {
                    if (isTagByte)
                    {
                        var Tag = Card[i];
                        TagMaisBytes = VerifyTagAMais(Card[i], Card[i + 1], Card[i + 2]);
                        var a = Card[i + 1 + TagMaisBytes];
                        DecLength = int.Parse(Card[i + 1 + TagMaisBytes], System.Globalization.NumberStyles.HexNumber);
                        TotalContent += "\r\n";
                        isTagByte = false;
                    }
                    else
                    {
                        if (Count == DecLength + TagMaisBytes)
                        {
                            isTagByte = true;
                            Count = 0;
                        }
                        else
                        {
                            Count++;
                        }
                    }

                    aplication2_length--;
                }

                #endregion

                TotalContent += Card[i] + " ";

                #region escreve quando acabar a primeira aplicacao
                if (aplication1_length == 0)
                {
                    aux = false;
                    aplication1_length--;
                    TotalContent += "\r\n";
                    TotalContent += "-------------";
                    TotalContent += "\r\n";
                }
                #endregion

                #region escreve quando acabar a segunda aplicacao
                if (aplication2_length == 0)
                {
                    aux = false;
                    aplication2_length--;
                    TotalContent += "\r\n";
                    TotalContent += "-------------";
                    TotalContent += "\r\n";
                }
                #endregion
            }

            return TotalContent;



        }

        public string SplitTLV(List<string> Bytes)
        {
            var isTagByte = true;
            var TotalContent = "";
            var Count = 0;
            var DecLength = 0;

            for (int i = 0; i < Bytes.Count; i++)
            {
                if (isTagByte)
                {
                    var Tag = Bytes[i];
                    var HexaLength = Bytes[i + 1];
                    DecLength = int.Parse(Bytes[i + 1], System.Globalization.NumberStyles.HexNumber);
                    TotalContent += "\r\n";
                    isTagByte = false;
                }
                else
                {
                    if (Count == DecLength)
                    {
                        isTagByte = true;
                        Count = 0;
                    }
                    else
                    {
                        Count++;
                    }
                }
                TotalContent += Bytes[i] + " ";
            }
            return TotalContent;
        }

        public int VerifyTagAMais(string tag1, string tag2, string tag3)
        {
            //ConfigTags = LeArquivoTagConfig(@"C:\Users\macedofl\Desktop\Tags.txt");

            foreach (var item in ConfigTags)
            {
                var configtag = item.Split(' ');
                if (configtag.Count() == 3 && configtag[0] != "" && configtag[1] != "" && configtag[2] != "")
                {
                    if (configtag[0] == tag1 && configtag[1] == tag2 && configtag[2] == tag3)
                    {
                        return 2;
                    }
                }
            }

            foreach (var item in ConfigTags)
            {
                var configtag = item.Split(' ');
                if (configtag.Count() > 1)
                {
                    if (configtag.Count() == 2 || configtag[2] == "")
                    {
                        if (configtag[0] == tag1 && configtag[1] == tag2)
                        {
                            return 1;
                        }
                    }
                }
            }

            return 0;
        }

        public List<string> LeArquivoTagConfig(string Path)
        {
            try
            {
                string[] lines = System.IO.File.ReadAllLines(Path);
                return lines.ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void EscreveArquivo(string savePath, string content, int cardNumber)
        {
            try
            {
                if (!Directory.Exists(savePath))
                {
                    Directory.CreateDirectory(savePath);
                }
                using (StreamWriter writer = new StreamWriter(savePath + @"\TagsFormatadas" + cardNumber + ".txt", true))
                {
                    writer.WriteLine("**********************************************");
                    writer.WriteLine("Card Number - " + cardNumber);
                    writer.WriteLine("DateTime - " + System.DateTime.Now);
                    writer.WriteLine(content);
                    writer.WriteLine("**********************************************");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro no caminho para save");
            }

        }
    }
}
