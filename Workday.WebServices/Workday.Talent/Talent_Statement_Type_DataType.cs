using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Talent
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Talent_Statement_Type_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string nameField;

		private string descriptionField;

		private bool display_on_Professional_ProfileField;

		private bool display_on_Professional_ProfileFieldSpecified;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private bool in_UseField;

		private bool in_UseFieldSpecified;

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
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				this.RaisePropertyChanged("Name");
			}
		}

		[XmlElement(Order = 2)]
		public string Description
		{
			get
			{
				return this.descriptionField;
			}
			set
			{
				this.descriptionField = value;
				this.RaisePropertyChanged("Description");
			}
		}

		[XmlElement(Order = 3)]
		public bool Display_on_Professional_Profile
		{
			get
			{
				return this.display_on_Professional_ProfileField;
			}
			set
			{
				this.display_on_Professional_ProfileField = value;
				this.RaisePropertyChanged("Display_on_Professional_Profile");
			}
		}

		[XmlIgnore]
		public bool Display_on_Professional_ProfileSpecified
		{
			get
			{
				return this.display_on_Professional_ProfileFieldSpecified;
			}
			set
			{
				this.display_on_Professional_ProfileFieldSpecified = value;
				this.RaisePropertyChanged("Display_on_Professional_ProfileSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Inactive
		{
			get
			{
				return this.inactiveField;
			}
			set
			{
				this.inactiveField = value;
				this.RaisePropertyChanged("Inactive");
			}
		}

		[XmlIgnore]
		public bool InactiveSpecified
		{
			get
			{
				return this.inactiveFieldSpecified;
			}
			set
			{
				this.inactiveFieldSpecified = value;
				this.RaisePropertyChanged("InactiveSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool In_Use
		{
			get
			{
				return this.in_UseField;
			}
			set
			{
				this.in_UseField = value;
				this.RaisePropertyChanged("In_Use");
			}
		}

		[XmlIgnore]
		public bool In_UseSpecified
		{
			get
			{
				return this.in_UseFieldSpecified;
			}
			set
			{
				this.in_UseFieldSpecified = value;
				this.RaisePropertyChanged("In_UseSpecified");
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
