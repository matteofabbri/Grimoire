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
	public class Effort_Certification_Change_Reason_Code_Request_ReferencesType : INotifyPropertyChanged
	{
		private Effort_Certification_Change_Reason_CodeObjectType[] effort_Certification_Change_Reason_Code_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Effort_Certification_Change_Reason_Code_Reference", Order = 0)]
		public Effort_Certification_Change_Reason_CodeObjectType[] Effort_Certification_Change_Reason_Code_Reference
		{
			get
			{
				return this.effort_Certification_Change_Reason_Code_ReferenceField;
			}
			set
			{
				this.effort_Certification_Change_Reason_Code_ReferenceField = value;
				this.RaisePropertyChanged("Effort_Certification_Change_Reason_Code_Reference");
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
