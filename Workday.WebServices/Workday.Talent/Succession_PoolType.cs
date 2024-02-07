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
	public class Succession_PoolType : INotifyPropertyChanged
	{
		private Succession_PoolObjectType succession_Pool_ReferenceField;

		private Succession_Pool_DataType[] succession_Pool_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Succession_PoolObjectType Succession_Pool_Reference
		{
			get
			{
				return this.succession_Pool_ReferenceField;
			}
			set
			{
				this.succession_Pool_ReferenceField = value;
				this.RaisePropertyChanged("Succession_Pool_Reference");
			}
		}

		[XmlElement("Succession_Pool_Data", Order = 1)]
		public Succession_Pool_DataType[] Succession_Pool_Data
		{
			get
			{
				return this.succession_Pool_DataField;
			}
			set
			{
				this.succession_Pool_DataField = value;
				this.RaisePropertyChanged("Succession_Pool_Data");
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
