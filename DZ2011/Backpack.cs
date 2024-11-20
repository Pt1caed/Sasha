using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ2011
{
    internal class Backpack
    {
        Item[] items;

        public delegate void BackpackItem(Item item);
        public event BackpackItem? OnBackpackAdd;
        public event BackpackItem? OnBackpackRemove;

        public Backpack(string color, string company, string typetextile, double weight, double volume, int size_backpack)
        {
            Color = color;
            Company = company;
            TypeTextile = typetextile;
            Weight = weight;
            Volume = volume;

            items = new Item[size_backpack];
            VolumeNow = 0;
            
        }

        public double VolumeNow { get; private set; }
        public string? Color { get; set; }
        public string? Company { get; set; }
        public string? TypeTextile { get; set; }
        private double weight;
        private double volume;

        public void Add(Item item, int index)
        {
            if(index >= 0 && index < items.Length && VolumeNow + item.Volume < Volume)
            {
                items[index] = item;
                OnBackpackAdd?.Invoke(item);
                VolumeNow += item.Volume;
            }
        }
        public void Remove(int index)
        {
            if (index >= 0 && index < items.Length)
            {
                OnBackpackRemove?.Invoke(items[index]);
                VolumeNow -= items[index].Volume;

                Item[] temp = new Item[items.Length - 1];


                int counter = 0;
                for (int i = 0; i < items.Length; i++)
                {
                    if(i == index)
                    {
                        continue;
                    }
                    temp[counter] = items[i];
                    counter++;
                }
                items = temp;
            }
        }

        public double Weight
        {
            get { return weight; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Weight can't <=0");
                }
                weight = value;
            }
        }
        public double Volume
        {
            get { return volume; }
            set
            {
                if(value <= 0)
                {
                    throw new Exception("Volume can't <=0");
                }
                volume = value;
            }
        }
    }

    struct Item
    {
        public Item(string name, double weight, double volume)
        {
            Name = name;
            Weight = weight;
            Volume = volume;
        }
        private double volume;

        public string? Name { get; set; }
        public double Weight { get; private set; }
        public double Volume
        {
            get => volume;
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Volume can't <=0");
                }
                volume = value;
            }
        }
    }
}

