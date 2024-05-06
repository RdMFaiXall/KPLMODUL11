// deklarasi nama file MatematikaLibraries
namespace MatematikaLibraries
{
    // deklarasi class bernama MathLogic
    public class MathLogic
    {
        // deklarasi method void FPB
        public int FPB(int input1, int input2)
        {
            // kondisi jika input1 atau input2 bernilai0
            if (input1 == 0 || input2 == 0)
            {
                Console.WriteLine("0");
            }

            // perulagan untuk mencari nilai terbesar/FPB
            while (input2 != 0)
            {
                int temp = input2;
                input2 = input1 % input2;
                input1 = temp;
            }

            // mengeluarkan nilai input1/hasil olah FPB-nya
            return input1;
        }

        // deklarasi method void KPK
        public void KPK(int input1, int input2)
        {
            // mengkalikan input1 dan input2 lalu membaginya dengan nilai FPB
            Console.WriteLine("Output : " + (input1 * input2) / FPB(input1, input2));
        }

        // deklarasi method void Turunan
        public void Turunan(int[] inputInt)
        {
            // Set index 0 dikali dengan 3 lalu menempelkan string x2 dan set index 1 dikali 2 karena ditarik dari pangkat lalu
            // set index 2 dimajukan kedepan dari variabelnya
            Console.WriteLine("Output : " + inputInt[0] * 3 + "x2" + " + " + inputInt[1] * 2 + "X" + " + " + inputInt[2]);
        }

        // deklarasi method void Integral
        public String Integral(int[] inputInt)
        {
            // deklarasi string kosong pada variabel result
            String result = "";

            // deklarasi int first_num untuk menampung perhitungan
            int first_num;

            // algoritma untuk menentukan hasil integral dan langsung menjadikannya ke bentuk string
            for (int i = 0, pangkat = inputInt.Length - i - 1; i < inputInt.Length; i++, pangkat--)
            {
                first_num = inputInt[i] / (pangkat + 1);
                result += (first_num == 1 ? null : first_num.ToString(" + #; - #; 0")) + "x" + (i == inputInt.Length - 1 ? null : (pangkat + 1));
            }

            // mengeluarkan hasil pengolahan integral
            return (result[1].ToString() == "+" || result[1].ToString() == "-") ? result.Substring(3) : result + " + C";
        }
    }
}
