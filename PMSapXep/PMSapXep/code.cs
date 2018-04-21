using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PMSapXep
{
	class code
	{
		public void insertionsort(ListBox lb_code, Boolean tang)
		{

			lb_code.Items.Add("void InsertionSort(int a[], int n)");
			lb_code.Items.Add(" {");
			lb_code.Items.Add("   int i, pos, x;");
			lb_code.Items.Add("   for (i = 1; i < n; i++)");
			lb_code.Items.Add("      {");
			lb_code.Items.Add("         x = a[i];");
			lb_code.Items.Add("         pos = i - 1;");
			if (tang)
				lb_code.Items.Add("         while ((pos >= 0) && (a[pos] > x))");
			else
				lb_code.Items.Add("         while ((pos >= 0) && (a[pos] < x))");
			lb_code.Items.Add("           {");
			lb_code.Items.Add("            a[pos + 1] = a[pos];");
			lb_code.Items.Add("            pos--;");
			lb_code.Items.Add("           }");
			lb_code.Items.Add("         a[pos + 1] = x;");
			lb_code.Items.Add("      }");
			lb_code.Items.Add(" }");

		}
		public void Binaryinsertionsort(ListBox lb_code, Boolean tang)
		{
			lb_code.Items.Add("void BinaryInsertionSort(int* a, int N");
			lb_code.Items.Add(" {");
			lb_code.Items.Add("   int l, r, m, x; ");
			lb_code.Items.Add("   for (int i = 1; i < N; i++)");
			lb_code.Items.Add("      {");
			lb_code.Items.Add("         l = 0;");
			lb_code.Items.Add("         r = i - 1;");
			lb_code.Items.Add("         x = a[i];");
		}
		public void Selectionsort(ListBox lb_code, Boolean tang)
		{

			lb_code.Items.Add("void SelectionSort(int a[], int n) ");
			lb_code.Items.Add("  {");
			if (tang)

				lb_code.Items.Add("    int min, i, j; ");
			else
				lb_code.Items.Add("    int max, i, j; ");
			lb_code.Items.Add("    for (i = 0; i < n - 1; i++)");
			lb_code.Items.Add("       {     ");
			if (tang)
				lb_code.Items.Add("         min = i;      ");
			else
				lb_code.Items.Add("         max = i;      ");
			lb_code.Items.Add("         for (j = i + 1; j < n; j++)    ");
			if (tang)
			{
				lb_code.Items.Add("           if (a[j] < a[min])     ");
				lb_code.Items.Add("              min = j;      ");
				lb_code.Items.Add("         if (min != i)      ");
				lb_code.Items.Add("           Swap(a[min], a[i]);       ");
				lb_code.Items.Add("       }          ");
				lb_code.Items.Add("   }        ");
			}
			else
			{
				lb_code.Items.Add("           if (a[j] > a[max])     ");
				lb_code.Items.Add("              max = j;      ");
				lb_code.Items.Add("         if (max != i)      ");
				lb_code.Items.Add("           Swap(a[max], a[i]);       ");
				lb_code.Items.Add("       }          ");
				lb_code.Items.Add("   }        ");
			}
			lb_code.Items.Add("  void Swap(int &a,int &b)  {");
			lb_code.Items.Add("           int temp = a;");
			lb_code.Items.Add("            a = b;");
			lb_code.Items.Add("            b=temp;");
			lb_code.Items.Add(" }");
		}
		public void bubblesort(ListBox lb_code, Boolean tang)
		{
			lb_code.Items.Add("void BubbleSort(int a[],int n)");
			lb_code.Items.Add("  {");
			lb_code.Items.Add("     int i, j;");
			lb_code.Items.Add("     for (i = 0 ; i<n-1; i++)");
			lb_code.Items.Add("         for (j = n-1; j > i ; j --)");
			if (tang)
				lb_code.Items.Add("            if (a[j] < a[j-1]) ");
			else
				lb_code.Items.Add("            if (a[j] > a[j-1]) ");
			lb_code.Items.Add("              Swap(a[j], a[j-1]);");
			lb_code.Items.Add("  }");
			lb_code.Items.Add("  void Swap(int &a,int &b)  {");
			lb_code.Items.Add("           int temp = a;");
			lb_code.Items.Add("            a = b;");
			lb_code.Items.Add("            b=temp;");
			lb_code.Items.Add(" }");
		}

		public void heapsort(ListBox lb_code, Boolean tang)
		{
			lb_code.Items.Add("void HeapSort(int a[], int n)");
			lb_code.Items.Add("     {");
			lb_code.Items.Add("          int r;");
			lb_code.Items.Add("          CreateHeap(a, n);");
			lb_code.Items.Add("          r = n - 1;");
			lb_code.Items.Add("          while (r > 0)");
			lb_code.Items.Add("           {");
			lb_code.Items.Add("              Swap(a[0], a[r]);");
			lb_code.Items.Add("              r--;");
			lb_code.Items.Add("              if (r > 0)");
			lb_code.Items.Add("                 Shift(a, 0, r);");
			lb_code.Items.Add("           }");
			lb_code.Items.Add("      }");
			lb_code.Items.Add("void Shift(int a[], int l, int r)");
			lb_code.Items.Add("    {");
			lb_code.Items.Add("         int i, j, x;");
			lb_code.Items.Add("         i = l;");
			lb_code.Items.Add("         j = 2 * i + 1;");
			lb_code.Items.Add("         x = a[i];");
			lb_code.Items.Add("         while (j <= r)");
			lb_code.Items.Add("           {");
			lb_code.Items.Add("               if (j < r)");
			if (tang)
				lb_code.Items.Add("               if (a[j] < a[j+1])");
			else
				lb_code.Items.Add("               if (a[j] > a[j+1])");
			lb_code.Items.Add("                  j++;");
			if (tang)
				lb_code.Items.Add("               if (a[j] <= x)");
			else
				lb_code.Items.Add("               if (a[j] >= x)");
			lb_code.Items.Add("                  return;");
			lb_code.Items.Add("               else");
			lb_code.Items.Add("                 {");
			lb_code.Items.Add("                    a[i] = a[j];");
			lb_code.Items.Add("                    a[j] = x;");
			lb_code.Items.Add("                    i = j;");
			lb_code.Items.Add("                    j = 2 * i + 1;");
			lb_code.Items.Add("                    x = a[i];");
			lb_code.Items.Add("                 }");
			lb_code.Items.Add("            }");
			lb_code.Items.Add("    }");
			lb_code.Items.Add("void CreateHeap(int a[], int n)");
			lb_code.Items.Add("     {");
			lb_code.Items.Add("          int l = n / 2 - 1;");
			lb_code.Items.Add("          while (l >= 0)");
			lb_code.Items.Add("             {");
			lb_code.Items.Add("                 Shift(a, l, n-1);");
			lb_code.Items.Add("                  l--;");
			lb_code.Items.Add("             }");
			lb_code.Items.Add("     }");
			lb_code.Items.Add("  void Swap(int &a,int &b)  {");
			lb_code.Items.Add("           int temp = a;");
			lb_code.Items.Add("            a = b;");
			lb_code.Items.Add("            b=temp;");
			lb_code.Items.Add(" }");
		}
		public void Mergesort(ListBox lb_code, Boolean tang)
		{
			lb_code.Items.Add("        void MergeSort(int a[], int n)");
			lb_code.Items.Add("            { 	");
			lb_code.Items.Add("              int	k, nc=0, nb=0;");
			lb_code.Items.Add("              for (k = 1; k < n; k *= 2) ");
			lb_code.Items.Add("                {");
			lb_code.Items.Add("                  Distribute(a, n, nb, nc, k);");
			lb_code.Items.Add("                  Merge(a, nb, nc, k);");
			lb_code.Items.Add("                }");
			lb_code.Items.Add("    }");
			lb_code.Items.Add("void Distribute(int a[], int n, int &nb, int &nc, int k)");
			lb_code.Items.Add("     { 	");
			lb_code.Items.Add("            int i, pa, pb, pc;");
			lb_code.Items.Add("            pa = pb = pc = 0;");
			lb_code.Items.Add("            while (pa < n)");
			lb_code.Items.Add("              {");
			lb_code.Items.Add("                for (i = 0; (pa < n) && (i < k); i++, pa++, pb++)");
			lb_code.Items.Add("                    b[pb] = a[pa];");
			lb_code.Items.Add("                for (i = 0; (pa < n) && (i < k); i++, pa++, pc++)");
			lb_code.Items.Add("                    c[pc] = a[pa];");
			lb_code.Items.Add("              }");
			lb_code.Items.Add("            nb = pb;	");
			lb_code.Items.Add("            nc = pc;");
			lb_code.Items.Add("     }");
			lb_code.Items.Add("        int min(int a, int b)");
			lb_code.Items.Add("          {");
			lb_code.Items.Add("            if(a > b)");
			lb_code.Items.Add("                return b;");
			lb_code.Items.Add("            else");
			lb_code.Items.Add("                return a;");
			lb_code.Items.Add("          }");
			lb_code.Items.Add("        void Merge(int a[], int nb, int nc, int k)");
			lb_code.Items.Add("          {");
			lb_code.Items.Add("            int p, pb, pc, ib, ic, kb, kc;");
			lb_code.Items.Add("            p = pb = pc = 0; ib = ic = 0;");
			lb_code.Items.Add("            while((nb > 0) && (nc > 0))");
			lb_code.Items.Add("              {");
			lb_code.Items.Add("                kb = min(k, nb);");
			lb_code.Items.Add("                kc = min(k, nc);");
			if (tang)
				lb_code.Items.Add("                if(b[pb + ib] <= c[pc + ic])");
			else
				lb_code.Items.Add("                if(b[pb + ib] >= c[pc + ic])");
			lb_code.Items.Add("                  {");
			lb_code.Items.Add("                    a[p++]=b[pb+ib];");
			lb_code.Items.Add("                    ib++;");
			lb_code.Items.Add("                    if(ib == kb)");
			lb_code.Items.Add("                      { ");
			lb_code.Items.Add("                        for(;ic<kc;ic++)");
			lb_code.Items.Add("	                        a[p++] = c[pc+ic];");
			lb_code.Items.Add("                        pb += kb; ");
			lb_code.Items.Add("                        pc += kc; ");
			lb_code.Items.Add("                        ib = ic = 0;");
			lb_code.Items.Add("                        nb -= kb; ");
			lb_code.Items.Add("                        nc -= kc;");
			lb_code.Items.Add("                      }");
			lb_code.Items.Add("                  }");
			lb_code.Items.Add("                else");
			lb_code.Items.Add("                  {");
			lb_code.Items.Add("                    a[p++] = c[pc+ic];");
			lb_code.Items.Add("                    ic++;");
			lb_code.Items.Add("                    if(ic == kc)");
			lb_code.Items.Add("                      { 	");
			lb_code.Items.Add("                        for(; ib < kb; ib++)");
			lb_code.Items.Add("	                        a[p++] = b[pb+ib];");
			lb_code.Items.Add("                        pb += kb; ");
			lb_code.Items.Add("                        pc += kc; ");
			lb_code.Items.Add("                        ib = ic = 0;");
			lb_code.Items.Add("                        nb -= kb; ");
			lb_code.Items.Add("                        nc -= kc;");
			lb_code.Items.Add("                      }");
			lb_code.Items.Add("                   }");
			lb_code.Items.Add("              }");
			lb_code.Items.Add("           }");
		}
		public void quicksort(ListBox lb_code, Boolean tang)
		{
			lb_code.Items.Add("void QuickSort(int a[], int left, int right)");
			lb_code.Items.Add("     {");
			lb_code.Items.Add("            int i, j, x;");
			lb_code.Items.Add("            x = a[(left + right) / 2]; ");
			lb_code.Items.Add("            i = left; j = right;");
			lb_code.Items.Add("               do");
			lb_code.Items.Add("                  {");
			if (tang)
				lb_code.Items.Add("                   while(a[i] < x) i++;");
			else
				lb_code.Items.Add("                   while(a[i] > x) i++;");
			if (tang)
				lb_code.Items.Add("                   while(a[j] > x) j--;");
			else
				lb_code.Items.Add("                   while(a[j] < x) j--;");

			lb_code.Items.Add("                       if(i <= j");
			lb_code.Items.Add("                         { ");
			lb_code.Items.Add("                           Swap(a[i], a[j]);");
			lb_code.Items.Add("                           i++ ; j--;");
			lb_code.Items.Add("                         }");
			lb_code.Items.Add("                   }");
			lb_code.Items.Add("               while(i <= j);");
			lb_code.Items.Add("               if(left < j)");
			lb_code.Items.Add("                   QuickSort(a, left, j);");
			lb_code.Items.Add("               if(i < right)");
			lb_code.Items.Add("                   QuickSort(a, i, right);");
			lb_code.Items.Add("      }");
			lb_code.Items.Add("  void Swap(int &a,int &b)  {");
			lb_code.Items.Add("           int temp = a;");
			lb_code.Items.Add("            a = b;");
			lb_code.Items.Add("            b=temp;");
			lb_code.Items.Add(" }");


		}
		public void Interchangesort(ListBox lb_code, Boolean tang)
		{
			lb_code.Items.Add("void InterchangeSort(int a[], int N) ");
			lb_code.Items.Add("    {");
			lb_code.Items.Add("        int i, j;");
			lb_code.Items.Add("        for(i = 0; i < N - 1; i++)");
			lb_code.Items.Add("             for(j = i + 1; j < N; j++)");
			if (tang)
				lb_code.Items.Add("                 if (a[j] < a[i])");
			else
				lb_code.Items.Add("                 if (a[j] > a[i])");
			lb_code.Items.Add("                   Swap(a[i], a[j]);");
			lb_code.Items.Add("    }");
			lb_code.Items.Add("  void Swap(int &a,int &b)  {");
			lb_code.Items.Add("           int temp = a;");
			lb_code.Items.Add("            a = b;");
			lb_code.Items.Add("            b=temp;");
			lb_code.Items.Add(" }");
		}
		public void ShakerSort(ListBox lb_code, Boolean tang)
		{
			lb_code.Items.Add("void ShakeSort(int a[], int n)");
			lb_code.Items.Add("    {");
			lb_code.Items.Add("        int i, j;");
			lb_code.Items.Add("        int left, right, k;");
			lb_code.Items.Add("        left = 0;");
			lb_code.Items.Add("        right = n - 1;");
			lb_code.Items.Add("        k = n - 1;");
			lb_code.Items.Add("        while (left < right)");
			lb_code.Items.Add("          {");
			lb_code.Items.Add("                  for (j = right; j > left; j--)");
			lb_code.Items.Add("                    if (a[j] < a[j - 1])");
			lb_code.Items.Add("                      {");
			lb_code.Items.Add("                        Swap(a[j], a[j - 1]);");
			lb_code.Items.Add("                        k = j;");
			lb_code.Items.Add("                      }");
			lb_code.Items.Add("                  left = k;");
			lb_code.Items.Add("                  for (j = left; j < right; j++)");
			lb_code.Items.Add("                    if (a[j] > a[j + 1])");
			lb_code.Items.Add("                      {");
			lb_code.Items.Add("                        Swap(a[j], a[j - 1]);");
			lb_code.Items.Add("                        k = j;");
			lb_code.Items.Add("          }");
			lb_code.Items.Add("        right = k; }");
			lb_code.Items.Add("    }");
			lb_code.Items.Add("  void Swap(int &a,int &b)  {");
			lb_code.Items.Add("           int temp = a;");
			lb_code.Items.Add("            a = b;");
			lb_code.Items.Add("            b=temp;");
			lb_code.Items.Add(" }");
		}

	}
}
