﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList
{
    public class LinkedList
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);

        }


        public void AddInReverseOrder(int data)            // To Display Add Elements In Reverse Order
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                head = newNode;
                head.next = temp;
            }
            Console.WriteLine("{0} inserted into linked list  ", newNode.data);
        }

        public void Append(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node node1 = head;
                while (node1.next != null)
                {
                    node1 = node1.next;
                }
                node1.next = node;
            }
        }

        internal Node InsertAtParticularPosition(int position, int data)        // Insert Element In Givien Position
        {
            Node newestNode = new Node(data);
            if (this.head == null)
            {
                return newestNode;
            }
            if (position == 0)
            {
                newestNode.next = this.head;
                this.head = newestNode;
                return this.head;
            }
            Node? prev = null;
            Node current = this.head;
            int count = 0;
            while (current != null && count < position)
            {
                prev = current;
                current = current.next;
                count++;
            }
            newestNode.next = prev.next;
            prev.next = newestNode;
            return this.head;
        }



        public void Display()
            {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("linked list is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}