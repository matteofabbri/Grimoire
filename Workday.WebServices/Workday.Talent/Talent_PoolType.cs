using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Talent
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Talent_PoolType : INotifyPropertyChanged
	{
		private Talent_Management_PoolObjectType static_Talent_Pool_ReferenceField;

		private Talent_Pool_DataType talent_Pool_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Talent_Management_PoolObjectType Static_Talent_Pool_Reference
		{
			get
			{
				return this.static_Talent_Pool_ReferenceField;
			}
			set
			{
				this.static_Talent_Pool_ReferenceField = value;
				this.RaisePropertyChanged("Static_Talent_Pool_Reference");
			}
		}

		[XmlElement(Order = 1)]
		public Talent_Pool_DataType Talent_Pool_Data
		{
			get
			{
				return this.talent_Pool_DataField;
			}
			set
			{
				this.talent_Pool_DataField = value;
				this.RaisePropertyChanged("Talent_Pool_Data");
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
