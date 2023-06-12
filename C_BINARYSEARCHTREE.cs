using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;


public class Node
{
    public Node LeftNode { get; set; }
    public Node RightNode { get; set; }
    public Contact Data { get; set; }
    public Node(Contact contact)
    {
        this.Data = contact;
    }
    public bool IsLeaf()
    {
        if (LeftNode == null && RightNode == null)
            return true;
        return false;
    }
}
public class BinarySearchTree
{
    public int Count_Node = 0;
    public Node Root { get; set; }
    public void InsertNodeRoot(Node root)
    {
        this.Root = root;
    }
    public bool Insert(Contact contact)
    {
        Node before = null, after = this.Root;
        while (after != null)
        {
            before = after;
            if (contact.ConvertDateToNumber() <= after.Data.ConvertDateToNumber())
                after = after.LeftNode;
            else if (contact.ConvertDateToNumber() > after.Data.ConvertDateToNumber())
                after = after.RightNode;
            else
                return false;
        }
        Node newNode = new Node(contact);
        if (this.Root == null)
            this.Root = newNode;
        else
        {
            if (contact.ConvertDateToNumber() <= before.Data.ConvertDateToNumber())
                before.LeftNode = newNode;
            else
                before.RightNode = newNode;
        }
        Count_Node++;
        return true;
    }
    public void GetContactTree(string file_name)
    {
        string line;
        string[] words;
        StreamReader infile = File.OpenText(file_name);
        // Đọc tiêu đề
        string line0 = infile.ReadLine(); 
        while (infile.Peek() != -1)
        {
            line = infile.ReadLine();
            // Không sử dụng tiêu đề
            if (line.Equals(line0)) 
                continue;
            words = line.Split(',');
            Contact item = new Contact(words[0], words[1], words[2], words[3]);
            Insert(item);
        }
        infile.Close();
    }
    public void TraverseInOrder(Node parent)
    {
        if (parent != null)
        {
            TraverseInOrder(parent.LeftNode);
            Console.WriteLine(parent.Data.ToString());
            TraverseInOrder(parent.RightNode);
        }
    }
    public void TraversePreOrder(Node parent)
    {
        if (parent != null)
        {
            Console.WriteLine(parent.Data.ToString());
            TraversePreOrder(parent.LeftNode);
            TraversePreOrder(parent.RightNode);
        }
    }
    private void FindByFullName(ListContact listContact, string name, Node parent)
    {
        name = name.Replace(" ", string.Empty);
        Contact contactNull = new Contact(null, null, null, null);
        string name_value;
        if (parent != null)
        {
            name_value = parent.Data.name.Replace(" ", string.Empty).ToString();
            if (name.Equals(name_value))
                listContact.AddContact(parent.Data);
            FindByFullName(listContact, name, parent.LeftNode);
            FindByFullName(listContact, name, parent.RightNode);
        }
    }
    private ListContact FindByFullName(string name)
    {
        ListContact listContact = new ListContact();
        FindByFullName(listContact, name, this.Root);
        return listContact;
    }
    private void FindByFirstName(ListContact lst, Node parent, string firstname)
    {
        firstname = firstname.Replace(" ", string.Empty);
        string[] name_arr;
        string firstname_value;
        string lastname_value;
        if (parent != null)
        {
            name_arr = parent.Data.name.Split(' ');
            firstname_value = name_arr[name_arr.Length - 1].Replace(" ", string.Empty).ToString();
            lastname_value = name_arr[0].Replace(" ", string.Empty).ToString();
            if (firstname_value.Equals(firstname)||lastname_value.Equals(firstname))
                lst.AddContact(parent.Data);
            FindByFirstName(lst, parent.LeftNode, firstname);
            FindByFirstName(lst, parent.RightNode, firstname);
        }
    }
    private ListContact FindByFirstName(string firstname)
    {
        ListContact lst = new ListContact();
        FindByFirstName(lst, this.Root, firstname);
        return lst;
    }
    public ListContact FindByName(string name)
    {
        ListContact lst = new ListContact();
        string[] name_arr = name.Split(' ');
        if (name_arr.Length == 1)
            lst = FindByFirstName(name);
        else
            lst = FindByFullName(name);
        return lst;
    }

    public Node Find(string date)
    {
        return Find(date, this.Root);
    }
    private Node Find(string date, Node parent)
    {
        if (parent != null)
        {
            Contact temp = new Contact(null, null, null, date);
            long date_value = temp.ConvertDateToNumber();
            long parent_date = parent.Data.ConvertDateToNumber();
            if (date_value == parent_date)
                return parent;
            if (date_value < parent_date)
                return Find(date, parent.LeftNode);
            else
                return Find(date, parent.RightNode);
        }
        return null;
    }
    public ListContact Find2(string date)
    {
        ListContact lst = new ListContact();
        Find2(lst, date, this.Root);
        return lst;
    }
    private void Find2(ListContact lst, string date, Node parent)
    {
        if (parent != null)
        {
            Contact temp = new Contact(null, null, null, date);
            long date_value = temp.ConvertDateToNumber();
            long parent_date = parent.Data.ConvertDateToNumber();
            if (date_value == parent_date)
                lst.AddContact(parent.Data);
            Find2(lst, date, parent.LeftNode);
            Find2(lst, date, parent.RightNode);
        }
    }
    public Contact FindContactMinDate(Node node)
    {
        Contact mincontact = node.Data;
        while (node.LeftNode != null)
        {
            mincontact = node.LeftNode.Data;
            node = node.LeftNode;
        }
        return mincontact;
    }
    public Contact FindContactMinDate()
    {
        return FindContactMinDate(this.Root);
    }
    public Contact FindContactMaxDate(Node node)
    {
        Contact maxcontact = node.Data;
        while (node.RightNode != null)
        {
            maxcontact = node.RightNode.Data;
            node = node.RightNode;
        }
        return maxcontact;
    }
    public Contact FindContactMaxDate()
    {
        return FindContactMaxDate(this.Root);
    }
    private void FindContactBetweenDate(ListContact listContact, Node node, string date1, string date2)
    {
        long date1_convert = new Contact(null, null, null, date1).ConvertDateToNumber();
        long date2_convert = new Contact(null, null, null, date2).ConvertDateToNumber();

        long date;
        if (node != null)
        {
            date = node.Data.ConvertDateToNumber();
            if (date >= date1_convert && date <= date2_convert)
                listContact.AddContact(node.Data);
            FindContactBetweenDate(listContact, node.LeftNode, date1, date2);
            FindContactBetweenDate(listContact, node.RightNode, date1, date2);
        }
    }
    public ListContact FindContactBetweenDate(string date1, string date2)
    {
        ListContact list = new ListContact();
        FindContactBetweenDate(list, this.Root, date1, date2);
        return list;
    }
    public void Remove(Contact contact)
    {
        this.Root = Remove(this.Root, contact);
        Count_Node--;
    }
    private Node Remove(Node parent, Contact cont)
    {
        long date_value = cont.ConvertDateToNumber();
        if (parent == null)
            return parent;
        if (date_value < parent.Data.ConvertDateToNumber())
            parent.LeftNode = Remove(parent.LeftNode, cont);
        else if (date_value > parent.Data.ConvertDateToNumber())
            parent.RightNode = Remove(parent.RightNode, cont);
        else
        {
            if (parent.LeftNode == null)
                return parent.RightNode;
            else if (parent.RightNode == null)
                return parent.LeftNode;
            parent.Data = FindContactMinDate(parent.RightNode);
            parent.RightNode = Remove(parent.RightNode, parent.Data);
        }
        return parent;
    }
}


