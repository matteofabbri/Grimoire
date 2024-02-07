using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Award_Group_Request_CriteriaType : INotifyPropertyChanged
	{
		private string award_Group_NameField;

		private Award_ContractObjectType[] award_ReferenceField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private bool activeField;

		private bool activeFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Award_Group_Name
		{
			get
			{
				return this.award_Group_NameField;
			}
			set
			{
				this.award_Group_NameField = value;
				this.RaisePropertyChanged("Award_Group_Name");
			}
		}

		[XmlElement("Award_Reference", Order = 1)]
		public Award_ContractObjectType[] Award_Reference
		{
			get
			{
				return this.award_ReferenceField;
			}
			set
			{
				this.award_ReferenceField = value;
				this.RaisePropertyChanged("Award_Reference");
			}
		}

		[XmlElement(Order = 2)]
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

		[XmlElement(Order = 3)]
		public bool Active
		{
			get
			{
				return this.activeField;
			}
			set
			{
				this.activeField = value;
				this.RaisePropertyChanged("Active");
			}
		}

		[XmlIgnore]
		public bool ActiveSpecified
		{
			get
			{
				return this.activeFieldSpecified;
			}
			set
			{
				this.activeFieldSpecified = value;
				this.RaisePropertyChanged("ActiveSpecified");
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
