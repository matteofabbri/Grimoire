using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Workday.FinancialManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Submit_1099_MISC_Adjustment_ResponseType : INotifyPropertyChanged
	{
		private XMLNAME_1099_MISC_AdjustmentObjectType xMLNAME_1099_MISC_Adjustment_ReferenceField;

		private string versionField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public XMLNAME_1099_MISC_AdjustmentObjectType XMLNAME_1099_MISC_Adjustment_Reference
		{
			get
			{
				return this.xMLNAME_1099_MISC_Adjustment_ReferenceField;
			}
			set
			{
				this.xMLNAME_1099_MISC_Adjustment_ReferenceField = value;
				this.RaisePropertyChanged("XMLNAME_1099_MISC_Adjustment_Reference");
			}
		}

		[XmlAttribute(Form = XmlSchemaForm.Qualified)]
		public string version
		{
			get
			{
				return this.versionField;
			}
			set
			{
				this.versionField = value;
				this.RaisePropertyChanged("version");
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
