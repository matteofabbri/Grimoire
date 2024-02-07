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
	public class VAT_Group_Request_ReferencesType : INotifyPropertyChanged
	{
		private VAT_GroupObjectType[] vAT_Group_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("VAT_Group_Reference", Order = 0)]
		public VAT_GroupObjectType[] VAT_Group_Reference
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
