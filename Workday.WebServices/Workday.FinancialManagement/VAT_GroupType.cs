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
	public class VAT_GroupType : INotifyPropertyChanged
	{
		private VAT_GroupObjectType vAT_Group_ReferenceField;

		private VAT_Group_DataType[] vAT_Group_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public VAT_GroupObjectType VAT_Group_Reference
		{
			get
			{
				return this.vAT_Group_ReferenceField;
			}
			set
			{
				this.vAT_Group_ReferenceField = value;
				this.RaisePropertyChanged("VAT_Group_Reference");
			}
		}

		[XmlElement("VAT_Group_Data", Order = 1)]
		public VAT_Group_DataType[] VAT_Group_Data
		{
			get
			{
				return this.vAT_Group_DataField;
			}
			set
			{
				this.vAT_Group_DataField = value;
				this.RaisePropertyChanged("VAT_Group_Data");
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
