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
	public class Change_Emergency_Contacts_Business_Process_DataType : INotifyPropertyChanged
	{
		private RoleObjectType person_ReferenceField;

		private bool replace_AllField;

		private bool replace_AllFieldSpecified;

		private Change_Emergency_Contacts_DataType[] emergency_Contacts_Reference_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public RoleObjectType Person_Reference
		{
			get
			{
				return this.person_ReferenceField;
			}
			set
			{
				this.person_ReferenceField = value;
				this.RaisePropertyChanged("Person_Reference");
			}
		}

		[XmlElement(Order = 1)]
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

		[XmlElement("Emergency_Contacts_Reference_Data", Order = 2)]
		public Change_Emergency_Contacts_DataType[] Emergency_Contacts_Reference_Data
		{
			get
			{
				return this.emergency_Contacts_Reference_DataField;
			}
			set
			{
				this.emergency_Contacts_Reference_DataField = value;
				this.RaisePropertyChanged("Emergency_Contacts_Reference_Data");
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
