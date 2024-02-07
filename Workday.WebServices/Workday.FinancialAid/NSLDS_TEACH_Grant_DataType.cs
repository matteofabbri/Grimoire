using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.FinancialAid
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class NSLDS_TEACH_Grant_DataType : INotifyPropertyChanged
	{
		private decimal tEACH_Grant_Sequence_NumberField;

		private bool tEACH_Grant_Sequence_NumberFieldSpecified;

		private string tEACH_OPEIDField;

		private DateTime tEACH_Grant_Last_Update_DateField;

		private bool tEACH_Grant_Last_Update_DateFieldSpecified;

		private decimal tEACH_Grant_Amount_Paid_to_DateField;

		private bool tEACH_Grant_Amount_Paid_to_DateFieldSpecified;

		private decimal tEACH_Grant_Award_AmountField;

		private bool tEACH_Grant_Award_AmountFieldSpecified;

		private Financial_Aid_Award_YearObjectType tEACH_Grant_Award_Year_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public decimal TEACH_Grant_Sequence_Number
		{
			get
			{
				return this.tEACH_Grant_Sequence_NumberField;
			}
			set
			{
				this.tEACH_Grant_Sequence_NumberField = value;
				this.RaisePropertyChanged("TEACH_Grant_Sequence_Number");
			}
		}

		[XmlIgnore]
		public bool TEACH_Grant_Sequence_NumberSpecified
		{
			get
			{
				return this.tEACH_Grant_Sequence_NumberFieldSpecified;
			}
			set
			{
				this.tEACH_Grant_Sequence_NumberFieldSpecified = value;
				this.RaisePropertyChanged("TEACH_Grant_Sequence_NumberSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public string TEACH_OPEID
		{
			get
			{
				return this.tEACH_OPEIDField;
			}
			set
			{
				this.tEACH_OPEIDField = value;
				this.RaisePropertyChanged("TEACH_OPEID");
			}
		}

		[XmlElement(DataType = "date", Order = 2)]
		public DateTime TEACH_Grant_Last_Update_Date
		{
			get
			{
				return this.tEACH_Grant_Last_Update_DateField;
			}
			set
			{
				this.tEACH_Grant_Last_Update_DateField = value;
				this.RaisePropertyChanged("TEACH_Grant_Last_Update_Date");
			}
		}

		[XmlIgnore]
		public bool TEACH_Grant_Last_Update_DateSpecified
		{
			get
			{
				return this.tEACH_Grant_Last_Update_DateFieldSpecified;
			}
			set
			{
				this.tEACH_Grant_Last_Update_DateFieldSpecified = value;
				this.RaisePropertyChanged("TEACH_Grant_Last_Update_DateSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public decimal TEACH_Grant_Amount_Paid_to_Date
		{
			get
			{
				return this.tEACH_Grant_Amount_Paid_to_DateField;
			}
			set
			{
				this.tEACH_Grant_Amount_Paid_to_DateField = value;
				this.RaisePropertyChanged("TEACH_Grant_Amount_Paid_to_Date");
			}
		}

		[XmlIgnore]
		public bool TEACH_Grant_Amount_Paid_to_DateSpecified
		{
			get
			{
				return this.tEACH_Grant_Amount_Paid_to_DateFieldSpecified;
			}
			set
			{
				this.tEACH_Grant_Amount_Paid_to_DateFieldSpecified = value;
				this.RaisePropertyChanged("TEACH_Grant_Amount_Paid_to_DateSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public decimal TEACH_Grant_Award_Amount
		{
			get
			{
				return this.tEACH_Grant_Award_AmountField;
			}
			set
			{
				this.tEACH_Grant_Award_AmountField = value;
				this.RaisePropertyChanged("TEACH_Grant_Award_Amount");
			}
		}

		[XmlIgnore]
		public bool TEACH_Grant_Award_AmountSpecified
		{
			get
			{
				return this.tEACH_Grant_Award_AmountFieldSpecified;
			}
			set
			{
				this.tEACH_Grant_Award_AmountFieldSpecified = value;
				this.RaisePropertyChanged("TEACH_Grant_Award_AmountSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public Financial_Aid_Award_YearObjectType TEACH_Grant_Award_Year_Reference
		{
			get
			{
				return this.tEACH_Grant_Award_Year_ReferenceField;
			}
			set
			{
				this.tEACH_Grant_Award_Year_ReferenceField = value;
				this.RaisePropertyChanged("TEACH_Grant_Award_Year_Reference");
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
