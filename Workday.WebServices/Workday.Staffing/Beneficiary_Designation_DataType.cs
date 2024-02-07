using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Beneficiary_Designation_DataType : INotifyPropertyChanged
	{
		private BeneficiaryObjectType beneficiary_ReferenceField;

		private DateTime original_Coverage_Begin_DateField;

		private DateTime coverage_End_DateField;

		private bool coverage_End_DateFieldSpecified;

		private Beneficiary_Allocation_DataType beneficiary_Allocation_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public BeneficiaryObjectType Beneficiary_Reference
		{
			get
			{
				return this.beneficiary_ReferenceField;
			}
			set
			{
				this.beneficiary_ReferenceField = value;
				this.RaisePropertyChanged("Beneficiary_Reference");
			}
		}

		[XmlElement(DataType = "date", Order = 1)]
		public DateTime Original_Coverage_Begin_Date
		{
			get
			{
				return this.original_Coverage_Begin_DateField;
			}
			set
			{
				this.original_Coverage_Begin_DateField = value;
				this.RaisePropertyChanged("Original_Coverage_Begin_Date");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime Coverage_End_Date
		{
			get
			{
				return this.coverage_End_DateField;
			}
			set
			{
				this.coverage_End_DateField = value;
				this.RaisePropertyChanged("Coverage_End_Date");
			}
		}

		[XmlIgnore]
		public bool Coverage_End_DateSpecified
		{
			get
			{
				return this.coverage_End_DateFieldSpecified;
			}
			set
			{
				this.coverage_End_DateFieldSpecified = value;
				this.RaisePropertyChanged("Coverage_End_DateSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public Beneficiary_Allocation_DataType Beneficiary_Allocation_Data
		{
			get
			{
				return this.beneficiary_Allocation_DataField;
			}
			set
			{
				this.beneficiary_Allocation_DataField = value;
				this.RaisePropertyChanged("Beneficiary_Allocation_Data");
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
