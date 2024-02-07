using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.Talent
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Talent_Pool_DataType : INotifyPropertyChanged
	{
		private string idField;

		private string nameField;

		private string descriptionField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private bool restricted_ViewField;

		private bool restricted_ViewFieldSpecified;

		private Static_Talent_Pool_MemberType[] talent_Pool_MemberField;

		private bool replace_AllField;

		private bool replace_AllFieldSpecified;

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
		public bool Restricted_View
		{
			get
			{
				return this.restricted_ViewField;
			}
			set
			{
				this.restricted_ViewField = value;
				this.RaisePropertyChanged("Restricted_View");
			}
		}

		[XmlIgnore]
		public bool Restricted_ViewSpecified
		{
			get
			{
				return this.restricted_ViewFieldSpecified;
			}
			set
			{
				this.restricted_ViewFieldSpecified = value;
				this.RaisePropertyChanged("Restricted_ViewSpecified");
			}
		}

		[XmlElement("Talent_Pool_Member", Order = 5)]
		public Static_Talent_Pool_MemberType[] Talent_Pool_Member
		{
			get
			{
				return this.talent_Pool_MemberField;
			}
			set
			{
				this.talent_Pool_MemberField = value;
				this.RaisePropertyChanged("Talent_Pool_Member");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public bool Replace_All
		{
			get
			{
				return this.replace_AllField;
			}
			set
			{
				this.replace_AllField = value;
				this.RaisePropertyChanged("Replace_All");
			}
		}

		[XmlIgnore]
		public bool Replace_AllSpecified
		{
			get
			{
				return this.replace_AllFieldSpecified;
			}
			set
			{
				this.replace_AllFieldSpecified = value;
				this.RaisePropertyChanged("Replace_AllSpecified");
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
