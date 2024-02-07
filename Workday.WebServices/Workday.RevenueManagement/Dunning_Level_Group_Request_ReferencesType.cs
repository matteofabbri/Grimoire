using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.RevenueManagement
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Dunning_Level_Group_Request_ReferencesType : INotifyPropertyChanged
	{
		private Dunning_Level_GroupObjectType[] dunning_Level_Group_ReferenceField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement("Dunning_Level_Group_Reference", Order = 0)]
		public Dunning_Level_GroupObjectType[] Dunning_Level_Group_Reference
		{
			get
			{
				return this.dunning_Level_Group_ReferenceField;
			}
			set
			{
				this.dunning_Level_Group_ReferenceField = value;
				this.RaisePropertyChanged("Dunning_Level_Group_Reference");
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
