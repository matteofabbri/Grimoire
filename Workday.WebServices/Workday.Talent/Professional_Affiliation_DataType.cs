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
	public class Professional_Affiliation_DataType : INotifyPropertyChanged
	{
		private string idField;

		private Professional_Affiliation_Type__All_ObjectType professional_Affiliation_Type_ReferenceField;

		private string nameField;

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
		public Professional_Affiliation_Type__All_ObjectType Professional_Affiliation_Type_Reference
		{
			get
			{
				return this.professional_Affiliation_Type_ReferenceField;
			}
			set
			{
				this.professional_Affiliation_Type_ReferenceField = value;
				this.RaisePropertyChanged("Professional_Affiliation_Type_Reference");
			}
		}

		[XmlElement(Order = 2)]
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
