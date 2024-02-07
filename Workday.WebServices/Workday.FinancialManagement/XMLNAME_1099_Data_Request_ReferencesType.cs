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
	public class XMLNAME_1099_Data_Request_ReferencesType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType electronic_Filing_1099_Run_Group_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Unique_IdentifierObjectType Electronic_Filing_1099_Run_Group_Reference
		{
			get
			{
				return this.electronic_Filing_1099_Run_Group_ReferenceField;
			}
			set
			{
				this.electronic_Filing_1099_Run_Group_ReferenceField = value;
				this.RaisePropertyChanged("Electronic_Filing_1099_Run_Group_Reference");
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
