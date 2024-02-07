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
	public class Worker_Role_DataType : INotifyPropertyChanged
	{
		private Organization_Role_for_Worker_DataType[] organization_Role_DataField;

		[method: CompilerGenerated]
		[CompilerGenerated]
		public event PropertyChangedEventHandler PropertyChanged;

		[XmlArray(Order = 0), XmlArrayItem("Organization_Role", IsNullable = false)]
		public Organization_Role_for_Worker_DataType[] Organization_Role_Data
		{
			get
			{
				return this.organization_Role_DataField;
			}
			set
			{
				this.organization_Role_DataField = value;
				this.RaisePropertyChanged("Organization_Role_Data");
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
