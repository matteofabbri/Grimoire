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
	public class Payroll_Result_Response_GroupType : INotifyPropertyChanged
	{
		private bool include_Name_DataField;

		private bool include_Name_DataFieldSpecified;

		private bool include_National_ID_DataField;

		private bool include_National_ID_DataFieldSpecified;

		private bool include_Related_Calculation_Result_DataField;

		private bool include_Related_Calculation_Result_DataFieldSpecified;

		private bool include_Withholding_Order_DataField;

		private bool include_Withholding_Order_DataFieldSpecified;

		private bool include_Payroll_Worktag_DataField;

		private bool include_Payroll_Worktag_DataFieldSpecified;

		private bool include_QTD_DataField;

		private bool include_QTD_DataFieldSpecified;

		private bool include_YTD_DataField;

		private bool include_YTD_DataFieldSpecified;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public bool Include_Name_Data
		{
			get
			{
				return this.include_Name_DataField;
			}
			set
			{
				this.include_Name_DataField = value;
				this.RaisePropertyChanged("Include_Name_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Name_DataSpecified
		{
			get
			{
				return this.include_Name_DataFieldSpecified;
			}
			set
			{
				this.include_Name_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Name_DataSpecified");
			}
		}

		[XmlElement(Order = 1)]
		public bool Include_National_ID_Data
		{
			get
			{
				return this.include_National_ID_DataField;
			}
			set
			{
				this.include_National_ID_DataField = value;
				this.RaisePropertyChanged("Include_National_ID_Data");
			}
		}

		[XmlIgnore]
		public bool Include_National_ID_DataSpecified
		{
			get
			{
				return this.include_National_ID_DataFieldSpecified;
			}
			set
			{
				this.include_National_ID_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_National_ID_DataSpecified");
			}
		}

		[XmlElement(Order = 2)]
		public bool Include_Related_Calculation_Result_Data
		{
			get
			{
				return this.include_Related_Calculation_Result_DataField;
			}
			set
			{
				this.include_Related_Calculation_Result_DataField = value;
				this.RaisePropertyChanged("Include_Related_Calculation_Result_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Related_Calculation_Result_DataSpecified
		{
			get
			{
				return this.include_Related_Calculation_Result_DataFieldSpecified;
			}
			set
			{
				this.include_Related_Calculation_Result_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Related_Calculation_Result_DataSpecified");
			}
		}

		[XmlElement(Order = 3)]
		public bool Include_Withholding_Order_Data
		{
			get
			{
				return this.include_Withholding_Order_DataField;
			}
			set
			{
				this.include_Withholding_Order_DataField = value;
				this.RaisePropertyChanged("Include_Withholding_Order_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Withholding_Order_DataSpecified
		{
			get
			{
				return this.include_Withholding_Order_DataFieldSpecified;
			}
			set
			{
				this.include_Withholding_Order_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Withholding_Order_DataSpecified");
			}
		}

		[XmlElement(Order = 4)]
		public bool Include_Payroll_Worktag_Data
		{
			get
			{
				return this.include_Payroll_Worktag_DataField;
			}
			set
			{
				this.include_Payroll_Worktag_DataField = value;
				this.RaisePropertyChanged("Include_Payroll_Worktag_Data");
			}
		}

		[XmlIgnore]
		public bool Include_Payroll_Worktag_DataSpecified
		{
			get
			{
				return this.include_Payroll_Worktag_DataFieldSpecified;
			}
			set
			{
				this.include_Payroll_Worktag_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_Payroll_Worktag_DataSpecified");
			}
		}

		[XmlElement(Order = 5)]
		public bool Include_QTD_Data
		{
			get
			{
				return this.include_QTD_DataField;
			}
			set
			{
				this.include_QTD_DataField = value;
				this.RaisePropertyChanged("Include_QTD_Data");
			}
		}

		[XmlIgnore]
		public bool Include_QTD_DataSpecified
		{
			get
			{
				return this.include_QTD_DataFieldSpecified;
			}
			set
			{
				this.include_QTD_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_QTD_DataSpecified");
			}
		}

		[XmlElement(Order = 6)]
		public bool Include_YTD_Data
		{
			get
			{
				return this.include_YTD_DataField;
			}
			set
			{
				this.include_YTD_DataField = value;
				this.RaisePropertyChanged("Include_YTD_Data");
			}
		}

		[XmlIgnore]
		public bool Include_YTD_DataSpecified
		{
			get
			{
				return this.include_YTD_DataFieldSpecified;
			}
			set
			{
				this.include_YTD_DataFieldSpecified = value;
				this.RaisePropertyChanged("Include_YTD_DataSpecified");
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
