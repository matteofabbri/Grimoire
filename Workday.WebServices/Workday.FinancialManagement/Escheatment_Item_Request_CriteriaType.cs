using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Escheatment_Item_Request_CriteriaType : INotifyPropertyChanged
	{
		private CompanyObjectType company_ReferenceField;

		private Document_StatusObjectType escheatment_Item_Status_ReferenceField;

		private DateTime escheatment_Item_DateField;

		private bool escheatment_Item_DateFieldSpecified;

		private DateTime start_DateField;

		private bool start_DateFieldSpecified;

		private DateTime end_DateField;

		private bool end_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public CompanyObjectType Company_Reference
		{
			get
			{
				return this.company_ReferenceField;
			}
			set
			{
				this.company_ReferenceField = value;
				this.RaisePropertyChanged("Company_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Document_StatusObjectType Escheatment_Item_Status_Reference
		{
			get
			{
				return this.escheatment_Item_Status_ReferenceField;
			}
			set
			{
				this.escheatment_Item_Status_ReferenceField = value;
				this.RaisePropertyChanged("Escheatment_Item_Status_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Escheatment_Item_Date
		{
			get
			{
				return this.escheatment_Item_DateField;
			}
			set
			{
				this.escheatment_Item_DateField = value;
				this.RaisePropertyChanged("Escheatment_Item_Date");
			}
		}

		[XmlIgnore]
		public bool Escheatment_Item_DateSpecified
		{
			get
			{
				return this.escheatment_Item_DateFieldSpecified;
			}
			set
			{
				this.escheatment_Item_DateFieldSpecified = value;
				this.RaisePropertyChanged("Escheatment_Item_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 3)]
		public DateTime Start_Date
		{
			get
			{
				return this.start_DateField;
			}
			set
			{
				this.start_DateField = value;
				this.RaisePropertyChanged("Start_Date");
			}
		}

		[XmlIgnore]
		public bool Start_DateSpecified
		{
			get
			{
				return this.start_DateFieldSpecified;
			}
			set
			{
				this.start_DateFieldSpecified = value;
				this.RaisePropertyChanged("Start_DateSpecified");
			}
		}

		[XmlElement(DataType = "date", Order = 4)]
		public DateTime End_Date
		{
			get
			{
				return this.end_DateField;
			}
			set
			{
				this.end_DateField = value;
				this.RaisePropertyChanged("End_Date");
			}
		}

		[XmlIgnore]
		public bool End_DateSpecified
		{
			get
			{
				return this.end_DateFieldSpecified;
			}
			set
			{
				this.end_DateFieldSpecified = value;
				this.RaisePropertyChanged("End_DateSpecified");
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
