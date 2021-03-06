﻿using System.Windows.Forms;
using System.Drawing;

public class CourseView
{
    public Label NameLabel;
    public TextBox DescriptionBox;
    public Panel ParentPanel;
    public string Name
    {
        get => NameLabel.Text;
        set => NameLabel.Text = value;
    }
    public string Description
    {
        get => DescriptionBox.Text;
        set => DescriptionBox.Text = value;
    }
    public CourseView(string CourseName, string CourseDescription, int offset, Panel ParentPanel)
    {
        this.ParentPanel = ParentPanel;
        NameLabel = new Label()
        {
            Text = CourseName,
            Font = new Font("Microsoft Sans Serif", 15.75f, FontStyle.Bold),
            Location = new Point(3, 1 + offset),
            Size = new Size(500, 25)
        };
        DescriptionBox = new TextBox()
        {
            Text = CourseDescription,
            Multiline = true,
            ReadOnly = true,
            Location = new Point(3, 29 + offset),
            Size = new Size(508, 61)
        };
        Draw();
    }
    public void ResetLocation(int offset)
    {
        NameLabel.Location = new Point(3, 1 + offset);
        DescriptionBox.Location = new Point(3, 29 + offset);
    }
    public void Draw()
    {
        ParentPanel.Controls.Add(NameLabel);
        ParentPanel.Controls.Add(DescriptionBox);
    }
    public void Clear()
    {
        ParentPanel.Controls.Remove(NameLabel);
        ParentPanel.Controls.Remove(DescriptionBox);
    }
}