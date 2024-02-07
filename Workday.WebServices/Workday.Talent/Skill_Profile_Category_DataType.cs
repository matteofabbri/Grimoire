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
	public class Skill_Profile_Category_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string skill_Profile_Category_NameField;

		private string descriptionField;

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
		public string Skill_Profile_Category_Name
		{
			get
			{
				return this.skill_Profile_Category_NameField;
			}
			set
			{
				this.skill_Profile_Category_NameField = value;
				this.RaisePropertyChanged("Skill_Profile_Category_Name");
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

		[XmlElement(Order = 4)]
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
