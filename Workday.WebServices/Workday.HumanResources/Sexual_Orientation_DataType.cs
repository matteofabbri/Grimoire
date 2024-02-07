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
	public class Sexual_Orientation_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string sexual_Orientation_NameField;

		private string sexual_Orientation_CodeField;

		private string sexual_Orientation_DescriptionField;

		private bool sexual_Orientation_InactiveField;

		private bool sexual_Orientation_InactiveFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string ID
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
				this.RaisePropertyChanged("ID");
			}
		}

		[XmlElement(Order = 1)]
		public string Sexual_Orientation_Name
		{
			get
			{
				return this.sexual_Orientation_NameField;
			}
			set
			{
				this.sexual_Orientation_NameField = value;
				this.RaisePropertyChanged("Sexual_Orientation_Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Sexual_Orientation_Code
		{
			get
			{
				return this.sexual_Orientation_CodeField;
			}
			set
			{
				this.sexual_Orientation_CodeField = value;
				this.RaisePropertyChanged("Sexual_Orientation_Code");
			}
		}

		[XmlElement(Order = 3)]
		public string Sexual_Orientation_Description
		{
			get
			{
				return this.sexual_Orientation_DescriptionField;
			}
			set
			{
				this.sexual_Orientation_DescriptionField = value;
				this.RaisePropertyChanged("Sexual_Orientation_Description");
			}
		}

		[XmlElement(Order = 4)]
		public bool Sexual_Orientation_Inactive
		{
			get
			{
				return this.sexual_Orientation_InactiveField;
			}
			set
			{
				this.sexual_Orientation_InactiveField = value;
				this.RaisePropertyChanged("Sexual_Orientation_Inactive");
			}
		}

		[XmlIgnore]
		public bool Sexual_Orientation_InactiveSpecified
		{
			get
			{
				return this.sexual_Orientation_InactiveFieldSpecified;
			}
			set
			{
				this.sexual_Orientation_InactiveFieldSpecified = value;
				this.RaisePropertyChanged("Sexual_Orientation_InactiveSpecified");
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
