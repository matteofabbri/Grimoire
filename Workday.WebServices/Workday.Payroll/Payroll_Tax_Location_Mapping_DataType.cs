using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payroll_Tax_Location_Mapping_DataType : INotifyPropertyChanged
	{
		private LocationObjectType location_ReferenceField;

		private DateTime effective_DateField;

		private bool inactiveField;

		private bool inactiveFieldSpecified;

		private Payroll_State_AuthorityObjectType payroll_State_Authority_ReferenceField;

		private Payroll_Local_County_AuthorityObjectType payroll_Local_County_Authority_ReferenceField;

		private Payroll_Local_City_AuthorityObjectType payroll_Local_City_Authority_ReferenceField;

		private Payroll_Other_AuthorityObjectType payroll_Other_Authority_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public LocationObjectType Location_Reference
		{
			get
			{
				return this.location_ReferenceField;
			}
			set
			{
				this.location_ReferenceField = value;
				this.RaisePropertyChanged("Location_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Effective_Date
		{
			get
			{
				return this.effective_DateField;
			}
			set
			{
				this.effective_DateField = value;
				this.RaisePropertyChanged("Effective_Date");
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
		public Payroll_State_AuthorityObjectType Payroll_State_Authority_Reference
		{
			get
			{
				return this.payroll_State_Authority_ReferenceField;
			}
			set
			{
				this.payroll_State_Authority_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_State_Authority_Reference");
			}
		}

		[XmlElement(Order = 4)]
		public Payroll_Local_County_AuthorityObjectType Payroll_Local_County_Authority_Reference
		{
			get
			{
				return this.payroll_Local_County_Authority_ReferenceField;
			}
			set
			{
				this.payroll_Local_County_Authority_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Local_County_Authority_Reference");
			}
		}

		[XmlElement(Order = 5)]
		public Payroll_Local_City_AuthorityObjectType Payroll_Local_City_Authority_Reference
		{
			get
			{
				return this.payroll_Local_City_Authority_ReferenceField;
			}
			set
			{
				this.payroll_Local_City_Authority_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Local_City_Authority_Reference");
			}
		}

		[XmlElement(Order = 6)]
		public Payroll_Other_AuthorityObjectType Payroll_Other_Authority_Reference
		{
			get
			{
				return this.payroll_Other_Authority_ReferenceField;
			}
			set
			{
				this.payroll_Other_Authority_ReferenceField = value;
				this.RaisePropertyChanged("Payroll_Other_Authority_Reference");
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
