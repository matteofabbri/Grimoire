using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.HumanResources
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Difficulty_to_Fill_DataType : INotifyPropertyChanged
	{
		private string difficulty_to_Fill_Sort_OrderField;

		private string difficulty_to_Fill_NameField;

		private string difficulty_to_Fill_CodeField;

		private string difficulty_to_Fill_DescriptionField;

		private bool difficulty_to_Fill_InactiveField;

		private bool difficulty_to_Fill_InactiveFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Difficulty_to_Fill_Sort_Order
		{
			get
			{
				return this.difficulty_to_Fill_Sort_OrderField;
			}
			set
			{
				this.difficulty_to_Fill_Sort_OrderField = value;
				this.RaisePropertyChanged("Difficulty_to_Fill_Sort_Order");
			}
		}

		[XmlElement(Order = 1)]
		public string Difficulty_to_Fill_Name
		{
			get
			{
				return this.difficulty_to_Fill_NameField;
			}
			set
			{
				this.difficulty_to_Fill_NameField = value;
				this.RaisePropertyChanged("Difficulty_to_Fill_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Difficulty_to_Fill_Code
		{
			get
			{
				return this.difficulty_to_Fill_CodeField;
			}
			set
			{
				this.difficulty_to_Fill_CodeField = value;
				this.RaisePropertyChanged("Difficulty_to_Fill_Code");
			}
		}

		[XmlElement(Order = 3)]
		public string Difficulty_to_Fill_Description
		{
			get
			{
				return this.difficulty_to_Fill_DescriptionField;
			}
			set
			{
				this.difficulty_to_Fill_DescriptionField = value;
				this.RaisePropertyChanged("Difficulty_to_Fill_Description");
			}
		}

		[XmlElement(Order = 4)]
		public bool Difficulty_to_Fill_Inactive
		{
			get
			{
				return this.difficulty_to_Fill_InactiveField;
			}
			set
			{
				this.difficulty_to_Fill_InactiveField = value;
				this.RaisePropertyChanged("Difficulty_to_Fill_Inactive");
			}
		}

		[XmlIgnore]
		public bool Difficulty_to_Fill_InactiveSpecified
		{
			get
			{
				return this.difficulty_to_Fill_InactiveFieldSpecified;
			}
			set
			{
				this.difficulty_to_Fill_InactiveFieldSpecified = value;
				this.RaisePropertyChanged("Difficulty_to_Fill_InactiveSpecified");
			}
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
