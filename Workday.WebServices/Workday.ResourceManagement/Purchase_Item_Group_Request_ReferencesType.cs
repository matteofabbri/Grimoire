using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.ResourceManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Purchase_Item_Group_Request_ReferencesType : INotifyPropertyChanged
	{
		private Purchase_Item_GroupObjectType[] purchase_Item_Group_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Purchase_Item_Group_Reference", Order = 0)]
		public Purchase_Item_GroupObjectType[] Purchase_Item_Group_Reference
		{
			get
			{
				return this.purchase_Item_Group_ReferenceField;
			}
			set
			{
				this.purchase_Item_Group_ReferenceField = value;
				this.RaisePropertyChanged("Purchase_Item_Group_Reference");
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
