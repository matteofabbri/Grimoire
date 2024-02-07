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
	public class Facilities_and_Administration_Rate_Agreement_Request_CriteriaType : INotifyPropertyChanged
	{
		private string rate_Agreement_NameField;

		private Facilities_and_Admin_Basis_TypeObjectType rate_Agreement_Basis_Type_ReferenceField;

		private DateTime rate_Agreement_DateField;

		private bool rate_Agreement_DateFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public string Rate_Agreement_Name
		{
			get
			{
				return this.rate_Agreement_NameField;
			}
			set
			{
				this.rate_Agreement_NameField = value;
				this.RaisePropertyChanged("Rate_Agreement_Name");
			}
		}

		[XmlElement(Order = 1)]
		public Facilities_and_Admin_Basis_TypeObjectType Rate_Agreement_Basis_Type_Reference
		{
			get
			{
				return this.rate_Agreement_Basis_Type_ReferenceField;
			}
			set
			{
				this.rate_Agreement_Basis_Type_ReferenceField = value;
				this.RaisePropertyChanged("Rate_Agreement_Basis_Type_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Rate_Agreement_Date
		{
			get
			{
				return this.rate_Agreement_DateField;
			}
			set
			{
				this.rate_Agreement_DateField = value;
				this.RaisePropertyChanged("Rate_Agreement_Date");
			}
		}

		[XmlIgnore]
		public bool Rate_Agreement_DateSpecified
		{
			get
			{
				return this.rate_Agreement_DateFieldSpecified;
			}
			set
			{
				this.rate_Agreement_DateFieldSpecified = value;
				this.RaisePropertyChanged("Rate_Agreement_DateSpecified");
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
