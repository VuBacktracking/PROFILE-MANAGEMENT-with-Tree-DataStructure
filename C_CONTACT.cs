using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;

public class Contact
{
    public string number_id { get; set; }
    public string name { get; set; }
    public string contact_number { get; set; }
    public string date { get; set; }

    public Contact(string id, string name, string contact_number, string date)
    {
        this.number_id = id;
        this.name = name;
        this.contact_number = contact_number;
        this.date = date;
    }
    public override string ToString()
    {
        return   number_id + "," + name + "," + contact_number + "," + date;
    }
    public long ConvertDateToNumber()
    {
        long result = 0;
        long kc1 = 0; long kc2 = 0; long kc3 = 0;
        string[] s = this.date.Split('/');
        long[] dates = new long[s.Length];
        for (int i = 0; i < dates.Length; i++)
            dates[i] = long.Parse(s[i]);
        // Tính khoảng cách năm
        for (int i = 1900; i < dates[2]; i++)
            // Kiểm tra năm nhuận
            if ((i % 4 == 0 && i % 100 != 0) || i % 400 == 0) 
                kc1 += 366;
            else
                kc1 += 365;
        // Tính khoảng cách tháng
        for (int i = 1; i < dates[1]; i++) 
        {
            if (i == 2)
            {
                if ((dates[2] % 4 == 0 && dates[2] % 100 != 0) || dates[2] % 400 == 0)
                    kc2 += 29;
                else
                    kc2 += 28;
            }
            else if (i == 4 || i == 6 || i == 9 || i == 11)
                kc2 += 30;
            else
                kc2 += 31;
        }
        for (int i = 1; i < dates[0]; i++)
            kc3 += 1;

        result = kc1 + kc2 + kc3;
        return result;
    }
}
public class ListContact
{
    public int Count_Contact;
    public List<Contact> listContact;
    public ListContact()
    {
        Count_Contact = 0;
        listContact = new List<Contact>();
    }
    public void AddContact(Contact item)
    {
        listContact.Add(item);
        Count_Contact++;
        
    }
    public void RemoveContact(Contact item)
    {
        listContact.Remove(item);
        Count_Contact--;

    }
    public void GetContact(string file_name)
    {
        
        string line;
        string[] words;
        StreamReader infile = File.OpenText(file_name);
        string line0 = infile.ReadLine(); 
        while (infile.Peek() != -1)
        {
            line = infile.ReadLine();
            if (line.Equals(line0))
                continue;
            words = line.Split(',');
             
            Contact item = new Contact(words[0], words[1], words[2], words[3]);
            AddContact(item);
        }
        infile.Close();
    }
    public Contact GetValue(int index)
    {
        return listContact[index];
    }
    public void DisplayAllContact()
    {
        for (int i = 0; i < Count_Contact; i++)
        {
            Console.WriteLine(listContact[i].ToString());
        }
    }
}