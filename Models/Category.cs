﻿using System;

namespace WPF_CMS_Ecommerce.Model
{
    public class Category
    {
        public Category(string id, string title, string description, string active)
        {
            int id_;
            Int32.TryParse(id, out id_);
            Id = id_;

            Title = title;
            Description = description;

            int active_;
            Int32.TryParse(active, out active_);
            Active = active_;
        }

        private int id;
        private string title;
        private string description;
        private int active;

        public int Id { get => id; set => id = value; }
        public string Title { get => title; set => title = value; }
        public string Description { get => description; set => description = value; }
        public int Active { get => active; set => active = value; }

        public override string ToString()
        {
            return Title +"  : " + Id.ToString();
        }
    }
}
