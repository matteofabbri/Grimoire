using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

namespace Workday.Staffing
{
	[GeneratedCode("System.Xml", "4.6.1590.0"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "urn:com.workday/bsvc")]
	[Serializable]
	public class Collective_Agreement_Snapshot_DataType : INotifyPropertyChanged
	{
		private Collective_AgreementObjectType collective_Agreement_ReferenceField;

		private Collective_Agreement_Factor_Parameter_DataType[] collective_Agreement_FactorField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlElement(Order = 0)]
		public Collective_AgreementObjectType Collective_Agreement_Reference
		{
			get
			{
				return this.collective_Agreement_ReferenceField;
			}
			set
			{
				this.collective_Agreement_ReferenceField = value;
				this.RaisePropertyChanged("Collective_Agreement_Reference");
			}
		}

		[XmlElement("Collective_Agreement_Factor", Order = 1)]
		public Collective_Agreement_Factor_Parameter_DataType[] Collective_Agreement_Factor
		{
			get
			{
				return this.collective_Agreement_FactorField;
			}
			set
			{
				this.collective_Agreement_FactorField = value;
				this.RaisePropertyChanged("Collective_Agreement_Factor");
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
