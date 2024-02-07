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
	public class Escheatment_Item_Request_ReferencesType : INotifyPropertyChanged
	{
		private Escheatment_ItemObjectType[] escheatment_Item_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Escheatment_Item_Reference", Order = 0)]
		public Escheatment_ItemObjectType[] Escheatment_Item_Reference
		{
			get
			{
				return this.escheatment_Item_ReferenceField;
			}
			set
			{
				this.escheatment_Item_ReferenceField = value;
				this.RaisePropertyChanged("Escheatment_Item_Reference");
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
