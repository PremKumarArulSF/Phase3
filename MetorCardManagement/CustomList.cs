using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MetorCardManagement
{
    public partial class CustomList<Type>
    {
         private int _count;
         private int _capacity;
         public int Count{get{return _count;}}
         public int Capacity{get{return _capacity;}}
         private Type[] _arr;
         public Type this[int index]
         {
            get{return _arr[index];}
            set{_arr[index]=value;}
         }

         public  CustomList()
         {
            _count=0;
            _capacity=4;
            _arr=new Type[_capacity];
         }

         public CustomList(int size)
         {
            _count=0;
            _capacity=size;
            _arr=new Type[_capacity];
         }
         public void Add(Type element)
         {
               if(_count==_capacity)
               {
                 GrowSize();
               }
              _arr[_count++]=element;
         }
         public void GrowSize()

         {
            _capacity*=2;
            Type [] temp=new Type[_capacity];

            for(int i=0;i<_count;i++)
            {
                temp[i]=_arr[i];
            }
            _arr=temp;
         }
         public void AddRange(CustomList<Type> elements)
         {
            _capacity=_count+elements.Count+4;
            Type[] temp=new Type[_capacity];
            for(int i=0;i<_count;i++)
            {
                temp[i]=_arr[i];
            }
            int k=0;
            for(int i=_count;i<_count+elements.Count;i++)
            {
                temp[i]=elements[k++];
            }
            _arr=temp;
            _count=_count+elements.Count;
         }
         

    }
}