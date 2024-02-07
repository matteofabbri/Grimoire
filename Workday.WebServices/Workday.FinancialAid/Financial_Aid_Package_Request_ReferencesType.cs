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
	public class Financial_Aid_Package_Request_ReferencesType : INotifyPropertyChanged
	{
		private Financial_Aid_PackageObjectType[] financial_Aid_Package_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Financial_Aid_Package_Reference", Order = 0)]
		public Financial_Aid_PackageObjectType[] Financial_Aid_Package_Reference
		{
			get
			{
				return this.financial_Aid_Package_ReferenceField;
			}
			set
			{
				this.financial_Aid_Package_ReferenceField = value;
				this.RaisePropertyChanged("Financial_Aid_Package_Reference");
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
