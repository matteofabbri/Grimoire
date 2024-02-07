using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Business_Asset_Useful_Life_Update_DataType : INotifyPropertyChanged
	{
		private bool adjust_Useful_LifeField;

		private bool adjust_Useful_LifeFieldSpecified;

		private DateTime transaction_Effective_DateField;

		private bool transaction_Effective_DateFieldSpecified;

		private decimal useful_LifeField;

		private bool useful_LifeFieldSpecified;

		private DateTime depreciation_End_DateField;

		private bool depreciation_End_DateFieldSpecified;

		private Asset_BookObjectType[] restricted_to_Books_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Adjust_Useful_Life
		{
			get
			{
				return this.adjust_Useful_LifeField;
			}
			set
			{
				this.adjust_Useful_LifeField = value;
				this.RaisePropertyChanged("Adjust_Useful_Life");
			}
		}

		[XmlIgnore]
		public bool Adjust_Useful_LifeSpecified
		{
			get
			{
				return this.adjust_Useful_LifeFieldSpecified;
			}
			set
			{
				this.adjust_Useful_LifeFieldSpecified = value;
				this.RaisePropertyChanged("Adjust_Useful_LifeSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Transaction_Effective_Date
		{
			get
			{
				return this.transaction_Effective_DateField;
			}
			set
			{
				this.transaction_Effective_DateField = value;
				this.RaisePropertyChanged("Transaction_Effective_Date");
			}
		}

		[XmlIgnore]
		public bool Transaction_Effective_DateSpecified
		{
			get
			{
				return this.transaction_Effective_DateFieldSpecified;
			}
			set
			{
				this.transaction_Effective_DateFieldSpecified = value;
				this.RaisePropertyChanged("Transaction_Effective_DateSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public decimal Useful_Life
		{
			get
			{
				return this.useful_LifeField;
			}
			set
			{
				this.useful_LifeField = value;
				this.RaisePropertyChanged("Useful_Life");
			}
		}

		[XmlIgnore]
		public bool Useful_LifeSpecified
		{
			get
			{
				return this.useful_LifeFieldSpecified;
			}
			set
			{
				this.useful_LifeFieldSpecified = value;
				this.RaisePropertyChanged("Useful_LifeSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Depreciation_End_Date
		{
			get
			{
				return this.depreciation_End_DateField;
			}
			set
			{
				this.depreciation_End_DateField = value;
				this.RaisePropertyChanged("Depreciation_End_Date");
			}
		}

		[XmlIgnore]
		public bool Depreciation_End_DateSpecified
		{
			get
			{
				return this.depreciation_End_DateFieldSpecified;
			}
			set
			{
				this.depreciation_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Depreciation_End_DateSpecified");
			}
		}

		[XmlElement("Restricted_to_Books_Reference", Order = 4)]
		public Asset_BookObjectType[] Restricted_to_Books_Reference
		{
			get
			{
				return this.restricted_to_Books_ReferenceField;
			}
			set
			{
				this.restricted_to_Books_ReferenceField = value;
				this.RaisePropertyChanged("Restricted_to_Books_Reference");
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
