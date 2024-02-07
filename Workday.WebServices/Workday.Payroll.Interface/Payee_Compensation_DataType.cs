using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Payroll.Interface
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Payee_Compensation_DataType : INotifyPropertyChanged
	{
		private Compensation_Pay_EarningObjectType compensation_Element_ReferenceField;

		private bool base_PayField;

		private bool base_PayFieldSpecified;

		private Payee_Compensation_Earning_Detail_DataType[] compensation_Details_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Compensation_Pay_EarningObjectType Compensation_Element_Reference
		{
			get
			{
				return this.compensation_Element_ReferenceField;
			}
			set
			{
				this.compensation_Element_ReferenceField = value;
				this.RaisePropertyChanged("Compensation_Element_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public bool Base_Pay
		{
			get
			{
				return this.base_PayField;
			}
			set
			{
				this.base_PayField = value;
				this.RaisePropertyChanged("Base_Pay");
			}
		}

		[XmlIgnore]
		public bool Base_PaySpecified
		{
			get
			{
				return this.base_PayFieldSpecified;
			}
			set
			{
				this.base_PayFieldSpecified = value;
				this.RaisePropertyChanged("Base_PaySpecified");
			}
		}

		[XmlElement("Compensation_Details_Data", Order = 2)]
		public Payee_Compensation_Earning_Detail_DataType[] Compensation_Details_Data
		{
			get
			{
				return this.compensation_Details_DataField;
			}
			set
			{
				this.compensation_Details_DataField = value;
				this.RaisePropertyChanged("Compensation_Details_Data");
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
