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
	public class XMLNAME_1099_MiscType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType iRS_1099_Misc_ReferenceField;

		private XMLNAME_1099_Misc_DataType[] iRS_1099_Misc_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType IRS_1099_Misc_Reference
		{
			get
			{
				return this.iRS_1099_Misc_ReferenceField;
			}
			set
			{
				this.iRS_1099_Misc_ReferenceField = value;
				this.RaisePropertyChanged("IRS_1099_Misc_Reference");
			}
		}

		[XmlElement("IRS_1099_Misc_Data", Order = 1)]
		public XMLNAME_1099_Misc_DataType[] IRS_1099_Misc_Data
		{
			get
			{
				return this.iRS_1099_Misc_DataField;
			}
			set
			{
				this.iRS_1099_Misc_DataField = value;
				this.RaisePropertyChanged("IRS_1099_Misc_Data");
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
