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
	public class XMLNAME_1099_MISC_AdjustmentType : INotifyPropertyChanged
	{
		private XMLNAME_1099_MISC_AdjustmentObjectType iRS_1099_MISC_Adjustment_ReferenceField;

		private XMLNAME_1099_MISC_Adjustment_DataType[] iRS_1099_MISC_Adjustment_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public XMLNAME_1099_MISC_AdjustmentObjectType IRS_1099_MISC_Adjustment_Reference
		{
			get
			{
				return this.iRS_1099_MISC_Adjustment_ReferenceField;
			}
			set
			{
				this.iRS_1099_MISC_Adjustment_ReferenceField = value;
				this.RaisePropertyChanged("IRS_1099_MISC_Adjustment_Reference");
			}
		}

		[XmlElement("IRS_1099_MISC_Adjustment_Data", Order = 1)]
		public XMLNAME_1099_MISC_Adjustment_DataType[] IRS_1099_MISC_Adjustment_Data
		{
			get
			{
				return this.iRS_1099_MISC_Adjustment_DataField;
			}
			set
			{
				this.iRS_1099_MISC_Adjustment_DataField = value;
				this.RaisePropertyChanged("IRS_1099_MISC_Adjustment_Data");
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
