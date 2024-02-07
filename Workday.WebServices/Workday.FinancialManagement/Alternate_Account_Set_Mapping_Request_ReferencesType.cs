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
	public class Alternate_Account_Set_Mapping_Request_ReferencesType : INotifyPropertyChanged
	{
		private Unique_IdentifierObjectType[] alternate_Account_Set_Mapping_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Alternate_Account_Set_Mapping_Reference", Order = 0)]
		public Unique_IdentifierObjectType[] Alternate_Account_Set_Mapping_Reference
		{
			get
			{
				return this.alternate_Account_Set_Mapping_ReferenceField;
			}
			set
			{
				this.alternate_Account_Set_Mapping_ReferenceField = value;
				this.RaisePropertyChanged("Alternate_Account_Set_Mapping_Reference");
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
